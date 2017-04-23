namespace RSA_Base58_Block {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.cryptBtn = new System.Windows.Forms.Button();
            this.prime1Box = new System.Windows.Forms.TextBox();
            this.pLabel1 = new System.Windows.Forms.Label();
            this.prime2Box = new System.Windows.Forms.TextBox();
            this.pLabel2 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p1Len = new System.Windows.Forms.Label();
            this.p2Len = new System.Windows.Forms.Label();
            this.nLen = new System.Windows.Forms.Label();
            this.publicExpBox = new System.Windows.Forms.TextBox();
            this.genPrimesBtn = new System.Windows.Forms.Button();
            this.calcBtn = new System.Windows.Forms.Button();
            this.phiBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plaintextBox = new System.Windows.Forms.TextBox();
            this.decryptBox = new System.Windows.Forms.TextBox();
            this.plainLen = new System.Windows.Forms.Label();
            this.cryptBox = new System.Windows.Forms.TextBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.clearStatusTmr = new System.Windows.Forms.Timer(this.components);
            this.copyCryptBox = new System.Windows.Forms.Button();
            this.cryptLen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cryptBtn
            // 
            this.cryptBtn.Enabled = false;
            this.cryptBtn.Location = new System.Drawing.Point(198, 199);
            this.cryptBtn.Name = "cryptBtn";
            this.cryptBtn.Size = new System.Drawing.Size(128, 32);
            this.cryptBtn.TabIndex = 3;
            this.cryptBtn.Text = "Encrypt";
            this.cryptBtn.UseVisualStyleBackColor = true;
            this.cryptBtn.Click += new System.EventHandler(this.cryptBtn_Click);
            // 
            // prime1Box
            // 
            this.prime1Box.Location = new System.Drawing.Point(6, 36);
            this.prime1Box.Multiline = true;
            this.prime1Box.Name = "prime1Box";
            this.prime1Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prime1Box.Size = new System.Drawing.Size(450, 75);
            this.prime1Box.TabIndex = 7;
            this.prime1Box.TabStop = false;
            this.prime1Box.Text = "136589320176099525426657208594293045461";
            this.prime1Box.TextChanged += new System.EventHandler(this.prime1Box_TextChanged);
            // 
            // pLabel1
            // 
            this.pLabel1.AutoSize = true;
            this.pLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLabel1.Location = new System.Drawing.Point(6, 20);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(64, 13);
            this.pLabel1.TabIndex = 2;
            this.pLabel1.Text = "Prime1 (p)";
            // 
            // prime2Box
            // 
            this.prime2Box.Location = new System.Drawing.Point(6, 138);
            this.prime2Box.Multiline = true;
            this.prime2Box.Name = "prime2Box";
            this.prime2Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prime2Box.Size = new System.Drawing.Size(450, 75);
            this.prime2Box.TabIndex = 1;
            this.prime2Box.TabStop = false;
            this.prime2Box.Text = "105465541871269980916433451893816777927";
            this.prime2Box.TextChanged += new System.EventHandler(this.prime2Box_TextChanged);
            // 
            // pLabel2
            // 
            this.pLabel2.AutoSize = true;
            this.pLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLabel2.Location = new System.Drawing.Point(6, 122);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(64, 13);
            this.pLabel2.TabIndex = 2;
            this.pLabel2.Text = "Prime2 (q)";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(6, 342);
            this.nBox.Multiline = true;
            this.nBox.Name = "nBox";
            this.nBox.ReadOnly = true;
            this.nBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.nBox.Size = new System.Drawing.Size(450, 64);
            this.nBox.TabIndex = 3;
            this.nBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modulus (n)";
            // 
            // p1Len
            // 
            this.p1Len.AutoSize = true;
            this.p1Len.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Len.Location = new System.Drawing.Point(362, 20);
            this.p1Len.Name = "p1Len";
            this.p1Len.Size = new System.Drawing.Size(62, 13);
            this.p1Len.TabIndex = 9;
            this.p1Len.Text = "Lenght: --";
            // 
            // p2Len
            // 
            this.p2Len.AutoSize = true;
            this.p2Len.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Len.Location = new System.Drawing.Point(362, 122);
            this.p2Len.Name = "p2Len";
            this.p2Len.Size = new System.Drawing.Size(62, 13);
            this.p2Len.TabIndex = 8;
            this.p2Len.Text = "Lenght: --";
            // 
            // nLen
            // 
            this.nLen.AutoSize = true;
            this.nLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLen.Location = new System.Drawing.Point(362, 326);
            this.nLen.Name = "nLen";
            this.nLen.Size = new System.Drawing.Size(60, 13);
            this.nLen.TabIndex = 7;
            this.nLen.Text = "Bitsize: --";
            // 
            // publicExpBox
            // 
            this.publicExpBox.Location = new System.Drawing.Point(6, 292);
            this.publicExpBox.Name = "publicExpBox";
            this.publicExpBox.ReadOnly = true;
            this.publicExpBox.Size = new System.Drawing.Size(450, 20);
            this.publicExpBox.TabIndex = 11;
            this.publicExpBox.TabStop = false;
            this.publicExpBox.Text = "65537";
            // 
            // genPrimesBtn
            // 
            this.genPrimesBtn.Location = new System.Drawing.Point(82, 224);
            this.genPrimesBtn.Name = "genPrimesBtn";
            this.genPrimesBtn.Size = new System.Drawing.Size(150, 32);
            this.genPrimesBtn.TabIndex = 1;
            this.genPrimesBtn.Text = "Generate Prime Numbers";
            this.genPrimesBtn.UseVisualStyleBackColor = true;
            this.genPrimesBtn.Click += new System.EventHandler(this.genPrimesBtn_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(238, 224);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(150, 32);
            this.calcBtn.TabIndex = 0;
            this.calcBtn.Text = "Calculate Keys";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // phiBox
            // 
            this.phiBox.Location = new System.Drawing.Point(6, 429);
            this.phiBox.Multiline = true;
            this.phiBox.Name = "phiBox";
            this.phiBox.ReadOnly = true;
            this.phiBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.phiBox.Size = new System.Drawing.Size(450, 64);
            this.phiBox.TabIndex = 3;
            this.phiBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phi";
            // 
            // dBox
            // 
            this.dBox.Location = new System.Drawing.Point(6, 522);
            this.dBox.Multiline = true;
            this.dBox.Name = "dBox";
            this.dBox.ReadOnly = true;
            this.dBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dBox.Size = new System.Drawing.Size(450, 64);
            this.dBox.TabIndex = 3;
            this.dBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Private exponent (d)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Public exponent (e)";
            // 
            // plaintextBox
            // 
            this.plaintextBox.Location = new System.Drawing.Point(6, 36);
            this.plaintextBox.Multiline = true;
            this.plaintextBox.Name = "plaintextBox";
            this.plaintextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plaintextBox.Size = new System.Drawing.Size(512, 157);
            this.plaintextBox.TabIndex = 2;
            this.plaintextBox.Text = resources.GetString("plaintextBox.Text");
            this.plaintextBox.TextChanged += new System.EventHandler(this.plaintextBox_TextChanged);
            // 
            // decryptBox
            // 
            this.decryptBox.Location = new System.Drawing.Point(6, 429);
            this.decryptBox.Multiline = true;
            this.decryptBox.Name = "decryptBox";
            this.decryptBox.ReadOnly = true;
            this.decryptBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decryptBox.Size = new System.Drawing.Size(512, 157);
            this.decryptBox.TabIndex = 6;
            // 
            // plainLen
            // 
            this.plainLen.AutoSize = true;
            this.plainLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainLen.Location = new System.Drawing.Point(424, 20);
            this.plainLen.Name = "plainLen";
            this.plainLen.Size = new System.Drawing.Size(62, 13);
            this.plainLen.TabIndex = 2;
            this.plainLen.Text = "Lenght: --";
            // 
            // cryptBox
            // 
            this.cryptBox.Location = new System.Drawing.Point(6, 240);
            this.cryptBox.Multiline = true;
            this.cryptBox.Name = "cryptBox";
            this.cryptBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cryptBox.Size = new System.Drawing.Size(512, 128);
            this.cryptBox.TabIndex = 4;
            this.cryptBox.TextChanged += new System.EventHandler(this.cryptBox_TextChanged);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Enabled = false;
            this.decryptBtn.Location = new System.Drawing.Point(198, 374);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(128, 32);
            this.decryptBtn.TabIndex = 5;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 617);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1030, 22);
            this.statusStrip.TabIndex = 16;
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // clearStatusTmr
            // 
            this.clearStatusTmr.Interval = 4000;
            this.clearStatusTmr.Tick += new System.EventHandler(this.clearStatusTmr_Tick);
            // 
            // copyCryptBox
            // 
            this.copyCryptBox.Location = new System.Drawing.Point(469, 374);
            this.copyCryptBox.Name = "copyCryptBox";
            this.copyCryptBox.Size = new System.Drawing.Size(49, 23);
            this.copyCryptBox.TabIndex = 18;
            this.copyCryptBox.Text = "Copy";
            this.copyCryptBox.UseVisualStyleBackColor = true;
            this.copyCryptBox.Click += new System.EventHandler(this.copyCryptBox_Click);
            // 
            // cryptLen
            // 
            this.cryptLen.AutoSize = true;
            this.cryptLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cryptLen.Location = new System.Drawing.Point(424, 224);
            this.cryptLen.Name = "cryptLen";
            this.cryptLen.Size = new System.Drawing.Size(62, 13);
            this.cryptLen.TabIndex = 2;
            this.cryptLen.Text = "Lenght: --";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Source plaintext";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Encrypted";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Decrypted plaintext";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.copyCryptBox);
            this.groupBox1.Controls.Add(this.plaintextBox);
            this.groupBox1.Controls.Add(this.cryptBtn);
            this.groupBox1.Controls.Add(this.decryptBtn);
            this.groupBox1.Controls.Add(this.cryptBox);
            this.groupBox1.Controls.Add(this.decryptBox);
            this.groupBox1.Controls.Add(this.plainLen);
            this.groupBox1.Controls.Add(this.cryptLen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(492, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 602);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Implementation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pLabel1);
            this.groupBox2.Controls.Add(this.prime1Box);
            this.groupBox2.Controls.Add(this.calcBtn);
            this.groupBox2.Controls.Add(this.prime2Box);
            this.groupBox2.Controls.Add(this.genPrimesBtn);
            this.groupBox2.Controls.Add(this.p1Len);
            this.groupBox2.Controls.Add(this.publicExpBox);
            this.groupBox2.Controls.Add(this.p2Len);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nLen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pLabel2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.phiBox);
            this.groupBox2.Controls.Add(this.dBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 602);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "RSA Implementation Test";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cryptBtn;
        private System.Windows.Forms.Label pLabel1;
        private System.Windows.Forms.Label pLabel2;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label p1Len;
        private System.Windows.Forms.Label p2Len;
        private System.Windows.Forms.Label nLen;
        private System.Windows.Forms.TextBox publicExpBox;
        private System.Windows.Forms.Button genPrimesBtn;
        protected internal System.Windows.Forms.TextBox prime1Box;
        protected internal System.Windows.Forms.TextBox prime2Box;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.TextBox phiBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.TextBox plaintextBox;
        protected internal System.Windows.Forms.TextBox decryptBox;
        private System.Windows.Forms.Label plainLen;
        protected internal System.Windows.Forms.TextBox cryptBox;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.Timer clearStatusTmr;
        private System.Windows.Forms.Button copyCryptBox;
        private System.Windows.Forms.Label cryptLen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

