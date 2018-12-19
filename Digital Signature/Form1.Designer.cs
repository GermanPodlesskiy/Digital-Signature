namespace DigitalSignature
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxFD = new System.Windows.Forms.TextBox();
            this.textBoxFH = new System.Windows.Forms.TextBox();
            this.textBoxSD = new System.Windows.Forms.TextBox();
            this.textBoxSH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOpenF = new System.Windows.Forms.Button();
            this.buttonSaveK = new System.Windows.Forms.Button();
            this.buttonOpenK = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(47, 12);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(234, 20);
            this.textBoxP.TabIndex = 0;
            this.textBoxP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxP_KeyPress);
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(331, 35);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(234, 20);
            this.textBoxE.TabIndex = 3;
            this.textBoxE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxP_KeyPress);
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(331, 9);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(234, 20);
            this.textBoxQ.TabIndex = 1;
            this.textBoxQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxP_KeyPress);
            // 
            // textBoxFD
            // 
            this.textBoxFD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFD.Location = new System.Drawing.Point(47, 112);
            this.textBoxFD.Name = "textBoxFD";
            this.textBoxFD.ReadOnly = true;
            this.textBoxFD.Size = new System.Drawing.Size(234, 20);
            this.textBoxFD.TabIndex = 10;
            // 
            // textBoxFH
            // 
            this.textBoxFH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFH.Location = new System.Drawing.Point(331, 112);
            this.textBoxFH.Name = "textBoxFH";
            this.textBoxFH.ReadOnly = true;
            this.textBoxFH.Size = new System.Drawing.Size(234, 20);
            this.textBoxFH.TabIndex = 11;
            // 
            // textBoxSD
            // 
            this.textBoxSD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSD.Location = new System.Drawing.Point(47, 149);
            this.textBoxSD.Name = "textBoxSD";
            this.textBoxSD.ReadOnly = true;
            this.textBoxSD.Size = new System.Drawing.Size(234, 20);
            this.textBoxSD.TabIndex = 12;
            // 
            // textBoxSH
            // 
            this.textBoxSH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSH.Location = new System.Drawing.Point(331, 149);
            this.textBoxSH.Name = "textBoxSH";
            this.textBoxSH.ReadOnly = true;
            this.textBoxSH.Size = new System.Drawing.Size(234, 20);
            this.textBoxSH.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "E";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "File hash";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hash decrypted";
            // 
            // buttonOpenF
            // 
            this.buttonOpenF.Location = new System.Drawing.Point(331, 87);
            this.buttonOpenF.Name = "buttonOpenF";
            this.buttonOpenF.Size = new System.Drawing.Size(121, 19);
            this.buttonOpenF.TabIndex = 6;
            this.buttonOpenF.Text = "Open file";
            this.buttonOpenF.UseVisualStyleBackColor = true;
            this.buttonOpenF.Click += new System.EventHandler(this.ButtonOpenF_Click);
            // 
            // buttonSaveK
            // 
            this.buttonSaveK.Location = new System.Drawing.Point(15, 187);
            this.buttonSaveK.Name = "buttonSaveK";
            this.buttonSaveK.Size = new System.Drawing.Size(121, 20);
            this.buttonSaveK.TabIndex = 8;
            this.buttonSaveK.Text = "Save as signature";
            this.buttonSaveK.UseVisualStyleBackColor = true;
            this.buttonSaveK.Click += new System.EventHandler(this.ButtonSaveK_Click);
            // 
            // buttonOpenK
            // 
            this.buttonOpenK.Location = new System.Drawing.Point(160, 187);
            this.buttonOpenK.Name = "buttonOpenK";
            this.buttonOpenK.Size = new System.Drawing.Size(121, 20);
            this.buttonOpenK.TabIndex = 9;
            this.buttonOpenK.Text = "Open signature";
            this.buttonOpenK.UseVisualStyleBackColor = true;
            this.buttonOpenK.Click += new System.EventHandler(this.buttonOpenK_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Subscribe",
            "Check"});
            this.comboBox1.Location = new System.Drawing.Point(331, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "(Not chosen)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "N";
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(47, 64);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(234, 20);
            this.textBoxR.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "DEC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "HEX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "DEC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "HEX";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(47, 38);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(234, 20);
            this.textBoxD.TabIndex = 2;
            this.textBoxD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxP_KeyPress);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 217);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonOpenK);
            this.Controls.Add(this.buttonSaveK);
            this.Controls.Add(this.buttonOpenF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSD);
            this.Controls.Add(this.textBoxSH);
            this.Controls.Add(this.textBoxFD);
            this.Controls.Add(this.textBoxFH);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxFD;
        private System.Windows.Forms.TextBox textBoxFH;
        private System.Windows.Forms.TextBox textBoxSD;
        private System.Windows.Forms.TextBox textBoxSH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonOpenF;
        private System.Windows.Forms.Button buttonSaveK;
        private System.Windows.Forms.Button buttonOpenK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxD;
    }
}

