namespace RSA_Base58_Block {
    partial class genPrimesForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(genPrimesForm));
            this.startBtn = new System.Windows.Forms.Button();
            this.bitBox = new System.Windows.Forms.ComboBox();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.reportBox1 = new System.Windows.Forms.TextBox();
            this.reportBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(192, 325);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(119, 45);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // bitBox
            // 
            this.bitBox.FormattingEnabled = true;
            this.bitBox.Items.AddRange(new object[] {
            "2048",
            "1536",
            "1024",
            "768",
            "512",
            "256",
            "128"});
            this.bitBox.Location = new System.Drawing.Point(76, 325);
            this.bitBox.Name = "bitBox";
            this.bitBox.Size = new System.Drawing.Size(86, 21);
            this.bitBox.TabIndex = 11;
            // 
            // progressTimer
            // 
            this.progressTimer.Interval = 50;
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Enabled = false;
            this.acceptBtn.Location = new System.Drawing.Point(317, 325);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(119, 45);
            this.acceptBtn.TabIndex = 13;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(442, 325);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 45);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // reportBox1
            // 
            this.reportBox1.Location = new System.Drawing.Point(12, 28);
            this.reportBox1.Multiline = true;
            this.reportBox1.Name = "reportBox1";
            this.reportBox1.ReadOnly = true;
            this.reportBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reportBox1.Size = new System.Drawing.Size(552, 119);
            this.reportBox1.TabIndex = 14;
            // 
            // reportBox2
            // 
            this.reportBox2.Location = new System.Drawing.Point(12, 182);
            this.reportBox2.Multiline = true;
            this.reportBox2.Name = "reportBox2";
            this.reportBox2.ReadOnly = true;
            this.reportBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reportBox2.Size = new System.Drawing.Size(552, 119);
            this.reportBox2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Prime 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prime 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bitsize:";
            // 
            // genPrimesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 379);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportBox2);
            this.Controls.Add(this.reportBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.bitBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "genPrimesForm";
            this.Text = "Generate Prime Numbers";
            this.Load += new System.EventHandler(this.genPrimesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ComboBox bitBox;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox reportBox1;
        private System.Windows.Forms.TextBox reportBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}