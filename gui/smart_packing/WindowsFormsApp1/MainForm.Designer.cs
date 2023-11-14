namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.listFile = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBoxSelectedImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlateImage = new System.Windows.Forms.PictureBox();
            this.plateResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxListWebcam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxWebcam = new System.Windows.Forms.PictureBox();
            this.buttonPlayWebcam = new System.Windows.Forms.Button();
            this.pictureBoxCaptureWebcam = new System.Windows.Forms.PictureBox();
            this.buttonCaptureWebcam = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlateImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptureWebcam)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listFile
            // 
            this.listFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.listFile.FormattingEnabled = true;
            this.listFile.Location = new System.Drawing.Point(768, 0);
            this.listFile.Margin = new System.Windows.Forms.Padding(2);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(274, 716);
            this.listFile.TabIndex = 3;
            this.listFile.SelectedIndexChanged += new System.EventHandler(this.listFile_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Capture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxSelectedImage
            // 
            this.pictureBoxSelectedImage.Location = new System.Drawing.Point(46, 79);
            this.pictureBoxSelectedImage.Name = "pictureBoxSelectedImage";
            this.pictureBoxSelectedImage.Size = new System.Drawing.Size(301, 148);
            this.pictureBoxSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedImage.TabIndex = 5;
            this.pictureBoxSelectedImage.TabStop = false;
            // 
            // pictureBoxPlateImage
            // 
            this.pictureBoxPlateImage.Location = new System.Drawing.Point(46, 238);
            this.pictureBoxPlateImage.Name = "pictureBoxPlateImage";
            this.pictureBoxPlateImage.Size = new System.Drawing.Size(301, 148);
            this.pictureBoxPlateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlateImage.TabIndex = 6;
            this.pictureBoxPlateImage.TabStop = false;
            // 
            // plateResult
            // 
            this.plateResult.Location = new System.Drawing.Point(387, 238);
            this.plateResult.Name = "plateResult";
            this.plateResult.Size = new System.Drawing.Size(140, 20);
            this.plateResult.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plate Number";
            // 
            // comboBoxListWebcam
            // 
            this.comboBoxListWebcam.FormattingEnabled = true;
            this.comboBoxListWebcam.Location = new System.Drawing.Point(373, 467);
            this.comboBoxListWebcam.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxListWebcam.Name = "comboBoxListWebcam";
            this.comboBoxListWebcam.Size = new System.Drawing.Size(139, 21);
            this.comboBoxListWebcam.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Webcam";
            // 
            // pictureBoxWebcam
            // 
            this.pictureBoxWebcam.Location = new System.Drawing.Point(46, 445);
            this.pictureBoxWebcam.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxWebcam.Name = "pictureBoxWebcam";
            this.pictureBoxWebcam.Size = new System.Drawing.Size(322, 240);
            this.pictureBoxWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWebcam.TabIndex = 12;
            this.pictureBoxWebcam.TabStop = false;
            // 
            // buttonPlayWebcam
            // 
            this.buttonPlayWebcam.Location = new System.Drawing.Point(373, 491);
            this.buttonPlayWebcam.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlayWebcam.Name = "buttonPlayWebcam";
            this.buttonPlayWebcam.Size = new System.Drawing.Size(75, 28);
            this.buttonPlayWebcam.TabIndex = 13;
            this.buttonPlayWebcam.Text = "Select";
            this.buttonPlayWebcam.UseVisualStyleBackColor = true;
            this.buttonPlayWebcam.Click += new System.EventHandler(this.buttonPlayWebcam_Click);
            // 
            // pictureBoxCaptureWebcam
            // 
            this.pictureBoxCaptureWebcam.Location = new System.Drawing.Point(403, 537);
            this.pictureBoxCaptureWebcam.Name = "pictureBoxCaptureWebcam";
            this.pictureBoxCaptureWebcam.Size = new System.Drawing.Size(301, 148);
            this.pictureBoxCaptureWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaptureWebcam.TabIndex = 14;
            this.pictureBoxCaptureWebcam.TabStop = false;
            // 
            // buttonCaptureWebcam
            // 
            this.buttonCaptureWebcam.Location = new System.Drawing.Point(462, 491);
            this.buttonCaptureWebcam.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCaptureWebcam.Name = "buttonCaptureWebcam";
            this.buttonCaptureWebcam.Size = new System.Drawing.Size(75, 28);
            this.buttonCaptureWebcam.TabIndex = 15;
            this.buttonCaptureWebcam.Text = "Capture";
            this.buttonCaptureWebcam.UseVisualStyleBackColor = true;
            this.buttonCaptureWebcam.Click += new System.EventHandler(this.buttonCaptureWebcam_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 55);
            this.button3.TabIndex = 16;
            this.button3.Text = "User Management";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 716);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonCaptureWebcam);
            this.Controls.Add(this.pictureBoxCaptureWebcam);
            this.Controls.Add(this.buttonPlayWebcam);
            this.Controls.Add(this.pictureBoxWebcam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxListWebcam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plateResult);
            this.Controls.Add(this.pictureBoxPlateImage);
            this.Controls.Add(this.pictureBoxSelectedImage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlateImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptureWebcam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxSelectedImage;
        private System.Windows.Forms.PictureBox pictureBoxPlateImage;
        private System.Windows.Forms.TextBox plateResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxListWebcam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxWebcam;
        private System.Windows.Forms.Button buttonPlayWebcam;
        private System.Windows.Forms.PictureBox pictureBoxCaptureWebcam;
        private System.Windows.Forms.Button buttonCaptureWebcam;
        private System.Windows.Forms.Button button3;
    }
}

