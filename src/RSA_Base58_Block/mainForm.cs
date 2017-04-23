using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Numerics;
using System.Globalization;
using System.Security.Cryptography; //criptograficamente comprovado pRNG

using Base58Check;


namespace RSA_Base58_Block {
    public partial class mainForm : Form {

       
        BigInteger prime1, prime2, modulus, phi, publicExp, privateExp;
        RandomNumberGenerator rbg = RandomNumberGenerator.Create();

        public mainForm() {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e) {
            prime1Box_TextChanged(null, EventArgs.Empty);
            prime2Box_TextChanged(null, EventArgs.Empty);
            plaintextBox_TextChanged(null, EventArgs.Empty);
        }

        

        private void genPrimesBtn_Click(object sender, EventArgs e) {
            genPrimesForm frm = new genPrimesForm(this);
            frm.ShowDialog();//isso vai segurar a thread
            calcBtn.Focus();
        }

        

        private void calcBtn_Click(object sender, EventArgs e) {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            clearKey();
            if (calcPrivKey()) {
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                changeStatus("Calculate Private Key: completed in " + elapsedMs.ToString() + "ms");
            }
            else {
                changeStatus("Calculate Private Key: error");
            }
            
            
        }


        private void clearKey() {
            nBox.Text = "";
            nLen.Text = "Bitsize: --";
            phiBox.Text = "";
            dBox.Text = "";

            cryptBtn.Enabled = false;
            decryptBtn.Enabled = false;
            decryptBox.Text = "";
            cryptBox.Text = "";
            this.Refresh();
        }

        

        private bool calcPrivKey() {
            Debug.WriteLine("----Starting Calculations----");
            try {
                prime1 = BigInteger.Parse(prime1Box.Text);
                prime2 = BigInteger.Parse(prime2Box.Text);
                publicExp = BigInteger.Parse(publicExpBox.Text);
            } catch {
                MessageBox.Show("Please insert valid numbers.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            

            if (prime1 == prime2)
                return false;

            if(prime2 > prime1) {
                Debug.WriteLine("----Swapping Primes");
                prime1Box.Text = prime2.ToString();
                prime2Box.Text = prime1.ToString();
                prime1 = BigInteger.Parse(prime1Box.Text);
                prime2 = BigInteger.Parse(prime2Box.Text);
            }


            UInt16 prime1BitSize = prime1.GetBitsize();
            UInt16 prime2BitSize = prime2.GetBitsize();
            if(prime1BitSize < 126 || prime2BitSize < 126) {
                MessageBox.Show("Please insert numbers with at least 126 bits", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Tabela C.3 apendice C do NIST FIPS 186-4
            UInt16 testemunhas;
            if(prime1BitSize >= 1530 && prime2BitSize >= 1530) {            //1536
                testemunhas = 3;
            } else if(prime1BitSize >= 1020 && prime2BitSize >= 1020) {     //1024
                testemunhas = 4;
            } else if(prime1BitSize >= 508 && prime2BitSize >= 508) {       //512
                testemunhas = 5;
            } else {                                                        //default
                testemunhas = 20;
            }
            if (!prime1.IsProbablePrime(testemunhas) || !prime2.IsProbablePrime(testemunhas)) {
                MessageBox.Show("Both numbers must be prime.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            modulus = BigInteger.Multiply(prime1, prime2);
            nBox.Text = modulus.ToString();
            nLen.Text = "Bitsize: " + modulus.GetBitsize();

            phi = modulus - prime1 - prime2 + 1;
            phiBox.Text = phi.ToString();
            BigInteger gcd = BigInteger.GreatestCommonDivisor(publicExp, phi);
            Debug.WriteLine("gcd(e, phi): {0}", (object)gcd.ToString());
            if (gcd != 1) {
                MessageBox.Show("gcd(e, phi) != 1", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            privateExp = publicExp.modInverse(ref phi);
            dBox.Text = privateExp.ToString();
            BigInteger testD = BigInteger.Multiply(publicExp, privateExp) % phi;
            Debug.WriteLine("testD: {0}", (object)testD);
            if (gcd != 1) {
                MessageBox.Show("(e*d)%phi != 1", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            cryptBtn.Enabled = true;
            decryptBtn.Enabled = true;
            return true;
        }


        //================================================================================================

        private void changeStatus(String str) {
            clearStatusTmr.Stop();
            clearStatusTmr.Start();
            statusLbl.Text = str;
            System.Media.SystemSounds.Beep.Play();
        }

        private void clearStatusTmr_Tick(object sender, EventArgs e) {
            statusLbl.Text = "";
            clearStatusTmr.Stop();
        }

        //================================================================================================
        


        private void copyCryptBox_Click(object sender, EventArgs e) {
            Clipboard.SetText(cryptBox.Text);
        }

        private void cryptBox_TextChanged(object sender, EventArgs e) {
            cryptLen.Text = "Lenght: " + cryptBox.Text.Length.ToString();
        }




        //================================================================================================

        private void cryptBtn_Click(object sender, EventArgs e) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Debug.WriteLine("---Encrypt process");
            cryptBox.Text = "";
            this.Refresh();

            //Pegar tamanho dos blocos
            int blocklen = (modulus.GetBitsize() / 8) - 4;
            if (blocklen < 5) {
                MessageBox.Show("Key too small", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                changeStatus("PubEncrypt: error");
                return;
            }
            Debug.WriteLine("blocklen: {0}", blocklen);

            //blocklen = 2; //debug

            //Dividir plaintext em blocos
            byte[] plaintextArr = Encoding.UTF8.GetBytes(plaintextBox.Text);
            UInt16 blockCnt = 0;
            String finalString = "";
            foreach (byte[] plainBlock in plaintextArr.Slices(blocklen)) {
                Debug.WriteLine("{0}::\t{1}", blockCnt, (object)plainBlock.ToHexString());

                //Add padding
                byte[] withPadArr = new byte[plainBlock.Length + 4]; //4 bytes random
                byte[] padArr = new byte[4];
                rbg.GetBytes(padArr);
                padArr[0] &= (Byte)0x7F; //make sure the first bit is always zero. No negative numbers for us :D
                Debug.WriteLine("Pad: {0}", (object)padArr.ToHexString());
                Array.Copy(padArr, withPadArr, 4);
                Array.Copy(plainBlock, 0, withPadArr, 4, plainBlock.Length);


                Array.Reverse(withPadArr);
                BigInteger toCrypt = new BigInteger(withPadArr);
                ////Check size
                //Debug.WriteLine("toCrypt bitsize: {0}", (object)toCrypt.GetBitsize());
                //if (toCrypt.GetBitsize() > modulus.GetBitsize()) {
                //    MessageBox.Show("Mensagem muito grande para esta chave", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    changeStatus("PubEncrypt: error");
                //    return;
                //}


                BigInteger crypt = BigInteger.ModPow(toCrypt, publicExp, modulus);
                byte[] cryptArr = crypt.ToByteArray();
                String b58Enc = Base58CheckEncoding.Encode(cryptArr).ToString();
                Debug.WriteLine("Final: {0}", (object)b58Enc);
                finalString += b58Enc + "_";

                blockCnt++;
            }

            cryptBox.Text = finalString.TrimEnd('_');
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            changeStatus("PubEncrypt: completed in " + elapsedMs.ToString() + "ms");
        }




        private void decryptBtn_Click(object sender, EventArgs e) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Debug.WriteLine("---Decrypt process");
            decryptBox.Text = "";
            this.Refresh();



            String startString = cryptBox.Text;

            UInt16 blockCnt = 0;
            String finalString = "";
            foreach (string cryptBlock in startString.Split('_')) {
                Debug.WriteLine("{0}::\t{1}", blockCnt, (object)cryptBlock);
                //CryptText inicial
                byte[] cryptArr;
                try {
                    cryptArr = Base58CheckEncoding.Decode(cryptBlock);
                }
                catch {
                    //MessageBox.Show("xxxx", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    changeStatus("PrivDecrypt: error");
                    return;
                }

                Debug.WriteLine("crypt hex: {0}", (object)cryptArr.ToHexString());


                BigInteger crypt = new BigInteger(cryptArr);
                BigInteger decrypt = BigInteger.ModPow(crypt, privateExp, modulus);
                Debug.WriteLine("decrypt bitsize: {0}", (object)decrypt.GetBitsize());
                Debug.WriteLine("decrypt hex: {0}", (object)decrypt.ToByteArray().ToHexString());


                //Remove padding
                byte[] decryptWithPadArr = decrypt.ToByteArray();
                byte[] decryptArr = new byte[decryptWithPadArr.Length - 4];
                Array.Copy(decryptWithPadArr, decryptArr, decryptArr.Length);
                Array.Reverse(decryptArr);
                Debug.WriteLine("decryptArr hex: {0}", (object)decryptArr.ToHexString());

                String rsaDec = Encoding.UTF8.GetString(decryptArr);
                Debug.WriteLine("Final: {0}", (object)rsaDec);
                finalString += rsaDec;

                blockCnt++;
            }



            decryptBox.Text = finalString;
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            changeStatus("PrivDecrypt: completed in " + elapsedMs.ToString() + "ms");
        }



        //================================================================================================

        private void plaintextBox_TextChanged(object sender, EventArgs e) {
            plainLen.Text = "Lenght: " + plaintextBox.Text.Length.ToString();
        }

        private void prime1Box_TextChanged(object sender, EventArgs e) {
            prime1Box.Text = prime1Box.Text.Replace(",", "");
            prime1Box.Text = prime1Box.Text.Replace(".", "");
            prime1Box.Text = prime1Box.Text.Replace(" ", "");
            prime1Box.Text = prime1Box.Text.Replace(":", "");
            prime1Box.Text = prime1Box.Text.Trim();
            p1Len.Text = "Lenght: " + prime1Box.Text.Length.ToString();
            clearKey();
        }

        private void prime2Box_TextChanged(object sender, EventArgs e) {
            prime2Box.Text = prime2Box.Text.Replace(",", "");
            prime2Box.Text = prime2Box.Text.Replace(".", "");
            prime2Box.Text = prime2Box.Text.Replace(" ", "");
            prime2Box.Text = prime2Box.Text.Replace(":", "");
            prime2Box.Text = prime2Box.Text.Trim();
            p2Len.Text = "Lenght: " + prime2Box.Text.Length.ToString();
            clearKey();
        }
    }//fim class
}
