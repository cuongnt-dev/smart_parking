namespace WindowsFormsApp1.form
{
    partial class SystemManageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxEntrance1CamIn = new System.Windows.Forms.ComboBox();
            this.comboBoxEntrance2CamIn = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxEntrance1QRCode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxEntrance1CamOut = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEntranceState1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxEntrance2QRCode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxEntrance2CamOut = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEntranceState2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxControlMode = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Camera In";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxEntrance1CamIn
            // 
            this.comboBoxEntrance1CamIn.FormattingEnabled = true;
            this.comboBoxEntrance1CamIn.Location = new System.Drawing.Point(116, 81);
            this.comboBoxEntrance1CamIn.Name = "comboBoxEntrance1CamIn";
            this.comboBoxEntrance1CamIn.Size = new System.Drawing.Size(202, 24);
            this.comboBoxEntrance1CamIn.TabIndex = 3;
            // 
            // comboBoxEntrance2CamIn
            // 
            this.comboBoxEntrance2CamIn.FormattingEnabled = true;
            this.comboBoxEntrance2CamIn.Location = new System.Drawing.Point(116, 74);
            this.comboBoxEntrance2CamIn.Name = "comboBoxEntrance2CamIn";
            this.comboBoxEntrance2CamIn.Size = new System.Drawing.Size(202, 24);
            this.comboBoxEntrance2CamIn.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxEntrance1QRCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxEntrance1CamOut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxEntranceState1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxEntrance1CamIn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 223);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance 1";
            // 
            // comboBoxEntrance1QRCode
            // 
            this.comboBoxEntrance1QRCode.FormattingEnabled = true;
            this.comboBoxEntrance1QRCode.Location = new System.Drawing.Point(116, 156);
            this.comboBoxEntrance1QRCode.Name = "comboBoxEntrance1QRCode";
            this.comboBoxEntrance1QRCode.Size = new System.Drawing.Size(202, 24);
            this.comboBoxEntrance1QRCode.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "QR Code";
            // 
            // comboBoxEntrance1CamOut
            // 
            this.comboBoxEntrance1CamOut.FormattingEnabled = true;
            this.comboBoxEntrance1CamOut.Location = new System.Drawing.Point(116, 119);
            this.comboBoxEntrance1CamOut.Name = "comboBoxEntrance1CamOut";
            this.comboBoxEntrance1CamOut.Size = new System.Drawing.Size(202, 24);
            this.comboBoxEntrance1CamOut.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Camera Out";
            // 
            // comboBoxEntranceState1
            // 
            this.comboBoxEntranceState1.FormattingEnabled = true;
            this.comboBoxEntranceState1.Location = new System.Drawing.Point(116, 43);
            this.comboBoxEntranceState1.Name = "comboBoxEntranceState1";
            this.comboBoxEntranceState1.Size = new System.Drawing.Size(202, 24);
            this.comboBoxEntranceState1.TabIndex = 5;
            this.comboBoxEntranceState1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntranceState1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "State";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxEntrance2QRCode);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxEntrance2CamOut);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxEntranceState2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxEntrance2CamIn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(22, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 199);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrance 2";
            // 
            // comboBoxEntrance2QRCode
            // 
            this.comboBoxEntrance2QRCode.FormattingEnabled = true;
            this.comboBoxEntrance2QRCode.Location = new System.Drawing.Point(116, 156);
            this.comboBoxEntrance2QRCode.Name = "comboBoxEntrance2QRCode";
            this.comboBoxEntrance2QRCode.Size = new System.Drawing.Size(202, 24);
            this.comboBoxEntrance2QRCode.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "QR Code";
            // 
            // comboBoxEntrance2CamOut
            // 
            this.comboBoxEntrance2CamOut.FormattingEnabled = true;
            this.comboBoxEntrance2CamOut.Location = new System.Drawing.Point(116, 117);
            this.comboBoxEntrance2CamOut.Name = "comboBoxEntrance2CamOut";
            this.comboBoxEntrance2CamOut.Size = new System.Drawing.Size(202, 24);
            this.comboBoxEntrance2CamOut.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Camera Out";
            // 
            // comboBoxEntranceState2
            // 
            this.comboBoxEntranceState2.FormattingEnabled = true;
            this.comboBoxEntranceState2.Location = new System.Drawing.Point(116, 32);
            this.comboBoxEntranceState2.Name = "comboBoxEntranceState2";
            this.comboBoxEntranceState2.Size = new System.Drawing.Size(202, 24);
            this.comboBoxEntranceState2.TabIndex = 6;
            this.comboBoxEntranceState2.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntranceState2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "State";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Control Mode";
            // 
            // comboBoxControlMode
            // 
            this.comboBoxControlMode.FormattingEnabled = true;
            this.comboBoxControlMode.Location = new System.Drawing.Point(138, 32);
            this.comboBoxControlMode.Name = "comboBoxControlMode";
            this.comboBoxControlMode.Size = new System.Drawing.Size(202, 24);
            this.comboBoxControlMode.TabIndex = 14;
            // 
            // SystemManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 632);
            this.Controls.Add(this.comboBoxControlMode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "SystemManageForm";
            this.Text = "System Management";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SystemManageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxEntrance1CamIn;
        private System.Windows.Forms.ComboBox comboBoxEntrance2CamIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxEntranceState1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEntranceState2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEntrance1CamOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEntrance2CamOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEntrance1QRCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxEntrance2QRCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxControlMode;
    }
}