namespace SubstitiutionApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rc2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rc1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nmc = new System.Windows.Forms.TextBox();
            this.btnsinhK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEncypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rc2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 136);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cipher Text";
            // 
            // rc2
            // 
            this.rc2.Location = new System.Drawing.Point(181, 20);
            this.rc2.Name = "rc2";
            this.rc2.Size = new System.Drawing.Size(379, 94);
            this.rc2.TabIndex = 5;
            this.rc2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Văn bản mã C";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rc1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 130);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PlaintText";
            // 
            // rc1
            // 
            this.rc1.Location = new System.Drawing.Point(181, 21);
            this.rc1.Name = "rc1";
            this.rc1.Size = new System.Drawing.Size(379, 94);
            this.rc1.TabIndex = 2;
            this.rc1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Văn bản rõ P";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nmc);
            this.groupBox3.Controls.Add(this.btnsinhK);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 140);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Key";
            // 
            // nmc
            // 
            this.nmc.Location = new System.Drawing.Point(181, 35);
            this.nmc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmc.Multiline = true;
            this.nmc.Name = "nmc";
            this.nmc.Size = new System.Drawing.Size(350, 75);
            this.nmc.TabIndex = 10;
            this.nmc.TextChanged += new System.EventHandler(this.nmc_TextChanged);
            // 
            // btnsinhK
            // 
            this.btnsinhK.Location = new System.Drawing.Point(35, 92);
            this.btnsinhK.Name = "btnsinhK";
            this.btnsinhK.Size = new System.Drawing.Size(74, 28);
            this.btnsinhK.TabIndex = 3;
            this.btnsinhK.Text = "Sinh K";
            this.btnsinhK.UseVisualStyleBackColor = true;
            this.btnsinhK.Click += new System.EventHandler(this.btnsinhK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khoá mã hoá ( 1 - 97 )";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 31;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEncypt
            // 
            this.btnEncypt.Location = new System.Drawing.Point(113, 471);
            this.btnEncypt.Name = "btnEncypt";
            this.btnEncypt.Size = new System.Drawing.Size(85, 37);
            this.btnEncypt.TabIndex = 28;
            this.btnEncypt.Text = "Encypt";
            this.btnEncypt.UseVisualStyleBackColor = true;
            this.btnEncypt.Click += new System.EventHandler(this.btnEncypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(245, 471);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(85, 37);
            this.btnDecrypt.TabIndex = 29;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(113, 528);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 39);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(629, 28);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(454, 539);
            this.rtbDesc.TabIndex = 32;
            this.rtbDesc.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 591);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncypt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rc2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox nmc;
        private System.Windows.Forms.Button btnsinhK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEncypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtbDesc;
    }
}

