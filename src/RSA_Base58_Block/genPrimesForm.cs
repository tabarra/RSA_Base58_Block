using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

using System.Diagnostics;
using System.Numerics;
using System.Globalization;
using System.Security.Cryptography;

namespace RSA_Base58_Block {
    public partial class genPrimesForm : Form {

        BigInteger prime1, prime2;
        UInt16 prime1Cnt, prime2Cnt;
        Thread th1, th2;
        Stopwatch prime1Watch, prime2Watch;
        Boolean prime1Status, prime2Status;

        private mainForm mainFormObj = null;

        public genPrimesForm(Form callingForm) {
            mainFormObj = callingForm as mainForm;
            InitializeComponent();
        }

        private void genPrimesForm_Load(object sender, EventArgs e) {
            bitBox.SelectedIndex = 4;
        }


        private void startBtn_Click(object sender, EventArgs e) {
            startBtn.Enabled = false;
            acceptBtn.Enabled = false;
            bitBox.Enabled = false;

            progressTimer.Start();
            int bitsize = Convert.ToInt32(bitBox.SelectedItem);

            prime1 = new BigInteger(0);
            prime1Cnt = 0;
            prime1Status = false;
            th1 = new Thread(() => GenPrime(ref prime1, bitsize, ref prime1Cnt, ref prime1Watch));
            th1.IsBackground = true;
            th1.Start();

            prime2 = new BigInteger(0);
            prime2Cnt = 0;
            prime2Status = false;
            th2 = new Thread(() => GenPrime(ref prime2, bitsize, ref prime2Cnt, ref prime2Watch));
            th2.IsBackground = true;
            th2.Start();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            if (th1 != null)
                th1.Abort();
            th1 = null;
            if (th2 != null)
                th2.Abort();
            th2 = null;
            this.Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e) {
            mainFormObj.prime1Box.Text = prime1.ToString();
            mainFormObj.prime2Box.Text = prime2.ToString();
            cancelBtn_Click(null, EventArgs.Empty);
        }


        private void progressTimer_Tick(object sender, EventArgs e) {
            if (prime1 == 0) {
                reportBox1.Text = "Tests: " + prime1Cnt.ToString() + "\r\nElapsed:\r\nBitsize:\r\nPrime:";
            } else if(!prime1Status) {
                Debug.WriteLine("Prime1 okay");
                reportBox1.Text = "Tests: " + prime1Cnt.ToString();
                reportBox1.Text += "\r\nElapsed: " + prime1Watch.ElapsedMilliseconds + "ms";
                reportBox1.Text += "\r\nBitsize: " + prime1.GetBitsize().ToString();
                reportBox1.Text += "\r\nPrime: " + prime1.ToString();
                prime1Status = true;
            }

            if (prime2 == 0) {
                reportBox2.Text = "Tests: " + prime2Cnt.ToString() + "\r\nElapsed:\r\nBitsize:\r\nPrime:";
            } else if (!prime2Status) {
                Debug.WriteLine("Prime2 okay");
                reportBox2.Text = "Tests: " + prime2Cnt.ToString();
                reportBox2.Text += "\r\nElapsed: " + prime2Watch.ElapsedMilliseconds + "ms";
                reportBox2.Text += "\r\nBitsize: " + prime2.GetBitsize().ToString();
                reportBox2.Text += "\r\nPrime: " + prime2.ToString();
                prime2Status = true;
            }

            if (prime1 != 0 && prime2 != 0) {
                startBtn.Enabled = true;
                acceptBtn.Enabled = true;
                bitBox.Enabled = true;
                progressTimer.Stop();
                System.Media.SystemSounds.Beep.Play();
            }
        }



        private void GenPrime(ref BigInteger prime, int bitsize, ref UInt16 count, ref Stopwatch watch) {
            Debug.WriteLine("GenPrime Inicializado");
            
            RandomNumberGenerator rbg = RandomNumberGenerator.Create();
            int wlen = (bitsize / 8) + 1;

            byte[] bytes = new byte[wlen];
            BigInteger testPrime;
            rbg.GetBytes(bytes);
            bytes[wlen - 1] = 0x00;
            bytes[0] |= (Byte)0x01;
            testPrime = new BigInteger(bytes);

            Debug.WriteLine("-------");
            Debug.WriteLine("Inicial:\t{0}", testPrime);
            Debug.WriteLine("Bitsize:\t{0}", testPrime.GetBitsize());
            Debug.WriteLine("Bytes:\t\t" + bytes[wlen - 2].ToBinString() + " ... " + bytes[2].ToBinString() + " " + bytes[1].ToBinString() + " " + bytes[0].ToBinString());

            
            watch = System.Diagnostics.Stopwatch.StartNew();

            bool IsProbablePrime = false;
            while (!IsProbablePrime && count <= 2e3) {
                IsProbablePrime = false;
                count++;

                testPrime += 2;
                IsProbablePrime = testPrime.IsProbablePrime(5);
            }


            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Debug.WriteLine("-------");
            Debug.WriteLine("ElapsedMilliseconds: {0}", elapsedMs);
            Debug.WriteLine("Count: {0}", (count * 2));
            if (IsProbablePrime) {
                bytes = testPrime.ToByteArray();
                Debug.WriteLine("-------");
                Debug.WriteLine("Final:\t\t{0}", testPrime);
                Debug.WriteLine("Bitsize:\t{0}", testPrime.GetBitsize());
                Debug.WriteLine("Bytes:\t\t" + bytes[wlen - 2].ToBinString() + " ... " + bytes[2].ToBinString() + " " + bytes[1].ToBinString() + " " + bytes[0].ToBinString());
                prime = testPrime;
            } else {
                Debug.WriteLine("-------");
                Debug.WriteLine("Failed");
                prime = BigInteger.Zero;
            }
        }


        

        
    }
}
