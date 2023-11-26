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
            this.comboBoxEntranceCam1 = new System.Windows.Forms.ComboBox();
            this.comboBoxEntranceCam2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEntranceState1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEntranceState2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Camera";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxEntranceCam1
            // 
            this.comboBoxEntranceCam1.FormattingEnabled = true;
            this.comboBoxEntranceCam1.Location = new System.Drawing.Point(116, 81);
            this.comboBoxEntranceCam1.Name = "comboBoxEntranceCam1";
            this.comboBoxEntranceCam1.Size = new System.Drawing.Size(202, 24);
            this.comboBoxEntranceCam1.TabIndex = 3;
            // 
            // comboBoxEntranceCam2
            // 
            this.comboBoxEntranceCam2.FormattingEnabled = true;
            this.comboBoxEntranceCam2.Location = new System.Drawing.Point(116, 74);
            this.comboBoxEntranceCam2.Name = "comboBoxEntranceCam2";
            this.comboBoxEntranceCam2.Size = new System.Drawing.Size(202, 24);
            this.comboBoxEntranceCam2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxEntranceState1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxEntranceCam1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 136);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxEntranceState2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxEntranceCam2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(20, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 146);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrance 2";
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
            // comboBoxEntranceState1
            // 
            this.comboBoxEntranceState1.FormattingEnabled = true;
            this.comboBoxEntranceState1.Location = new System.Drawing.Point(116, 43);
            this.comboBoxEntranceState1.Name = "comboBoxEntranceState1";
            this.comboBoxEntranceState1.Size = new System.Drawing.Size(202, 24);
            this.comboBoxEntranceState1.TabIndex = 5;
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
            // comboBoxEntranceState2
            // 
            this.comboBoxEntranceState2.FormattingEnabled = true;
            this.comboBoxEntranceState2.Location = new System.Drawing.Point(116, 32);
            this.comboBoxEntranceState2.Name = "comboBoxEntranceState2";
            this.comboBoxEntranceState2.Size = new System.Drawing.Size(202, 24);
            this.comboBoxEntranceState2.TabIndex = 6;
            // 
            // SystemManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "SystemManageForm";
            this.Text = "System Management";
            this.Load += new System.EventHandler(this.SystemManageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxEntranceCam1;
        private System.Windows.Forms.ComboBox comboBoxEntranceCam2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxEntranceState1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEntranceState2;
        private System.Windows.Forms.Label label4;
    }
}