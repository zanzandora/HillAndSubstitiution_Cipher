namespace HillApp
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
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.rtKn = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rcMt = new System.Windows.Forms.RichTextBox();
            this.btnsinhIk = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnsinhK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nmc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rc2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rc1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbDes = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(301, 545);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 39);
            this.button9.TabIndex = 26;
            this.button9.Text = "Clear";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(170, 545);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 37);
            this.button8.TabIndex = 25;
            this.button8.Text = "Decrypt";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(51, 545);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 37);
            this.button7.TabIndex = 24;
            this.button7.Text = "Encypt";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // rtKn
            // 
            this.rtKn.Location = new System.Drawing.Point(104, 163);
            this.rtKn.Name = "rtKn";
            this.rtKn.Size = new System.Drawing.Size(374, 96);
            this.rtKn.TabIndex = 6;
            this.rtKn.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Khoá bản mã";
            // 
            // rcMt
            // 
            this.rcMt.Location = new System.Drawing.Point(104, 32);
            this.rcMt.Name = "rcMt";
            this.rcMt.Size = new System.Drawing.Size(374, 105);
            this.rcMt.TabIndex = 4;
            this.rcMt.Text = "";
            // 
            // btnsinhIk
            // 
            this.btnsinhIk.Location = new System.Drawing.Point(518, 199);
            this.btnsinhIk.Name = "btnsinhIk";
            this.btnsinhIk.Size = new System.Drawing.Size(104, 37);
            this.btnsinhIk.TabIndex = 9;
            this.btnsinhIk.Text = "Sinh IK";
            this.btnsinhIk.UseVisualStyleBackColor = true;
            this.btnsinhIk.Click += new System.EventHandler(this.btnsinhIk_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnsinhK
            // 
            this.btnsinhK.Location = new System.Drawing.Point(14, 102);
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
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khoá mã hoá";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(429, 543);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(85, 39);
            this.button10.TabIndex = 27;
            this.button10.Text = "Exit";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nmc);
            this.groupBox3.Controls.Add(this.btnsinhIk);
            this.groupBox3.Controls.Add(this.rtKn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rcMt);
            this.groupBox3.Controls.Add(this.btnsinhK);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(36, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 240);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Key";
            // 
            // nmc
            // 
            this.nmc.Location = new System.Drawing.Point(36, 64);
            this.nmc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmc.Name = "nmc";
            this.nmc.Size = new System.Drawing.Size(64, 22);
            this.nmc.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "L =";
            // 
            // rc2
            // 
            this.rc2.Location = new System.Drawing.Point(181, 20);
            this.rc2.Name = "rc2";
            this.rc2.Size = new System.Drawing.Size(436, 94);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rc2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(36, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 136);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cipher Text";
            // 
            // rc1
            // 
            this.rc1.Location = new System.Drawing.Point(181, 21);
            this.rc1.Name = "rc1";
            this.rc1.Size = new System.Drawing.Size(436, 94);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rc1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 130);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PlaintText";
            // 
            // rtbDes
            // 
            this.rtbDes.Location = new System.Drawing.Point(686, 33);
            this.rtbDes.Name = "rtbDes";
            this.rtbDes.Size = new System.Drawing.Size(412, 565);
            this.rtbDes.TabIndex = 28;
            this.rtbDes.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 610);
            this.Controls.Add(this.rtbDes);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RichTextBox rtKn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rcMt;
        private System.Windows.Forms.Button btnsinhIk;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnsinhK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rc2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nmc;
        private System.Windows.Forms.RichTextBox rtbDes;
    }
}

