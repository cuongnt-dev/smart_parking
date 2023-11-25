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
            this.comboBoxCheckinCam = new System.Windows.Forms.ComboBox();
            this.comboBoxCheckoutCam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBarier1 = new System.Windows.Forms.ComboBox();
            this.comboBoxBarier2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checkin Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Checkout Camera";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCheckinCam
            // 
            this.comboBoxCheckinCam.FormattingEnabled = true;
            this.comboBoxCheckinCam.Location = new System.Drawing.Point(177, 50);
            this.comboBoxCheckinCam.Name = "comboBoxCheckinCam";
            this.comboBoxCheckinCam.Size = new System.Drawing.Size(202, 24);
            this.comboBoxCheckinCam.TabIndex = 3;
            // 
            // comboBoxCheckoutCam
            // 
            this.comboBoxCheckoutCam.FormattingEnabled = true;
            this.comboBoxCheckoutCam.Location = new System.Drawing.Point(177, 95);
            this.comboBoxCheckoutCam.Name = "comboBoxCheckoutCam";
            this.comboBoxCheckoutCam.Size = new System.Drawing.Size(202, 24);
            this.comboBoxCheckoutCam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Barier 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Barier 2";
            // 
            // comboBoxBarier1
            // 
            this.comboBoxBarier1.FormattingEnabled = true;
            this.comboBoxBarier1.Location = new System.Drawing.Point(177, 147);
            this.comboBoxBarier1.Name = "comboBoxBarier1";
            this.comboBoxBarier1.Size = new System.Drawing.Size(202, 24);
            this.comboBoxBarier1.TabIndex = 7;
            this.comboBoxBarier1.SelectedIndexChanged += new System.EventHandler(this.comboBoxBarier1_SelectedIndexChanged);
            // 
            // comboBoxBarier2
            // 
            this.comboBoxBarier2.FormattingEnabled = true;
            this.comboBoxBarier2.Location = new System.Drawing.Point(177, 188);
            this.comboBoxBarier2.Name = "comboBoxBarier2";
            this.comboBoxBarier2.Size = new System.Drawing.Size(202, 24);
            this.comboBoxBarier2.TabIndex = 8;
            // 
            // SystemManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 339);
            this.Controls.Add(this.comboBoxBarier2);
            this.Controls.Add(this.comboBoxBarier1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCheckoutCam);
            this.Controls.Add(this.comboBoxCheckinCam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SystemManageForm";
            this.Text = "System Management";
            this.Load += new System.EventHandler(this.SystemManageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCheckinCam;
        private System.Windows.Forms.ComboBox comboBoxCheckoutCam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBarier1;
        private System.Windows.Forms.ComboBox comboBoxBarier2;
    }
}