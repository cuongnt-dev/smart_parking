namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listFile = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBoxSelectedImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.listFile.Location = new System.Drawing.Point(570, 0);
            this.listFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(274, 426);
            this.listFile.TabIndex = 3;
            this.listFile.SelectedIndexChanged += new System.EventHandler(this.listFile_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Capture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxSelectedImage
            // 
            this.pictureBoxSelectedImage.Location = new System.Drawing.Point(46, 38);
            this.pictureBoxSelectedImage.Name = "pictureBoxSelectedImage";
            this.pictureBoxSelectedImage.Size = new System.Drawing.Size(351, 338);
            this.pictureBoxSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedImage.TabIndex = 5;
            this.pictureBoxSelectedImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 426);
            this.Controls.Add(this.pictureBoxSelectedImage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxSelectedImage;
    }
}

