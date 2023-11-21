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
            this.buttonCaptureCheckin = new System.Windows.Forms.Button();
            this.pictureBoxSelectedImageCheckin = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlateImageCheckout = new System.Windows.Forms.PictureBox();
            this.plateResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxListWebcamCheckin = new System.Windows.Forms.ComboBox();
            this.pictureBoxWebcamCheckin = new System.Windows.Forms.PictureBox();
            this.pictureBoxWebcamCheckout = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCheckin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOpenCheckinStream = new System.Windows.Forms.Button();
            this.buttonOpenCheckoutStream = new System.Windows.Forms.Button();
            this.comboBoxListWebcamCheckout = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCaptureCheckout = new System.Windows.Forms.Button();
            this.buttonTestCapture = new System.Windows.Forms.Button();
            this.textBoxCardId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImageCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlateImageCheckout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcamCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcamCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCaptureCheckin
            // 
            this.buttonCaptureCheckin.Location = new System.Drawing.Point(11, 656);
            this.buttonCaptureCheckin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCaptureCheckin.Name = "buttonCaptureCheckin";
            this.buttonCaptureCheckin.Size = new System.Drawing.Size(100, 28);
            this.buttonCaptureCheckin.TabIndex = 4;
            this.buttonCaptureCheckin.Text = "Capture";
            this.buttonCaptureCheckin.UseVisualStyleBackColor = true;
            this.buttonCaptureCheckin.Click += new System.EventHandler(this.buttonCaptureCheckin_Click);
            // 
            // pictureBoxSelectedImageCheckin
            // 
            this.pictureBoxSelectedImageCheckin.Location = new System.Drawing.Point(11, 433);
            this.pictureBoxSelectedImageCheckin.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSelectedImageCheckin.Name = "pictureBoxSelectedImageCheckin";
            this.pictureBoxSelectedImageCheckin.Size = new System.Drawing.Size(362, 165);
            this.pictureBoxSelectedImageCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedImageCheckin.TabIndex = 5;
            this.pictureBoxSelectedImageCheckin.TabStop = false;
            // 
            // pictureBoxPlateImageCheckout
            // 
            this.pictureBoxPlateImageCheckout.Location = new System.Drawing.Point(401, 433);
            this.pictureBoxPlateImageCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPlateImageCheckout.Name = "pictureBoxPlateImageCheckout";
            this.pictureBoxPlateImageCheckout.Size = new System.Drawing.Size(376, 165);
            this.pictureBoxPlateImageCheckout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlateImageCheckout.TabIndex = 6;
            this.pictureBoxPlateImageCheckout.TabStop = false;
            // 
            // plateResult
            // 
            this.plateResult.Location = new System.Drawing.Point(119, 659);
            this.plateResult.Margin = new System.Windows.Forms.Padding(4);
            this.plateResult.Name = "plateResult";
            this.plateResult.Size = new System.Drawing.Size(185, 22);
            this.plateResult.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 639);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plate Number";
            // 
            // comboBoxListWebcamCheckin
            // 
            this.comboBoxListWebcamCheckin.FormattingEnabled = true;
            this.comboBoxListWebcamCheckin.Location = new System.Drawing.Point(106, 118);
            this.comboBoxListWebcamCheckin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxListWebcamCheckin.Name = "comboBoxListWebcamCheckin";
            this.comboBoxListWebcamCheckin.Size = new System.Drawing.Size(107, 24);
            this.comboBoxListWebcamCheckin.TabIndex = 10;
            this.comboBoxListWebcamCheckin.SelectedIndexChanged += new System.EventHandler(this.comboBoxListWebcamCheckin_SelectedIndexChanged);
            // 
            // pictureBoxWebcamCheckin
            // 
            this.pictureBoxWebcamCheckin.Location = new System.Drawing.Point(16, 153);
            this.pictureBoxWebcamCheckin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxWebcamCheckin.Name = "pictureBoxWebcamCheckin";
            this.pictureBoxWebcamCheckin.Size = new System.Drawing.Size(357, 250);
            this.pictureBoxWebcamCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWebcamCheckin.TabIndex = 12;
            this.pictureBoxWebcamCheckin.TabStop = false;
            // 
            // pictureBoxWebcamCheckout
            // 
            this.pictureBoxWebcamCheckout.Location = new System.Drawing.Point(401, 153);
            this.pictureBoxWebcamCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxWebcamCheckout.Name = "pictureBoxWebcamCheckout";
            this.pictureBoxWebcamCheckout.Size = new System.Drawing.Size(376, 250);
            this.pictureBoxWebcamCheckout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWebcamCheckout.TabIndex = 14;
            this.pictureBoxWebcamCheckout.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 68);
            this.button3.TabIndex = 16;
            this.button3.Text = "User Management";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(171, 15);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 68);
            this.button4.TabIndex = 17;
            this.button4.Text = "Parking Management";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 68);
            this.button1.TabIndex = 18;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelCheckin
            // 
            this.labelCheckin.AutoSize = true;
            this.labelCheckin.Location = new System.Drawing.Point(13, 126);
            this.labelCheckin.Name = "labelCheckin";
            this.labelCheckin.Size = new System.Drawing.Size(55, 16);
            this.labelCheckin.TabIndex = 19;
            this.labelCheckin.Text = "Checkin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Checkout";
            // 
            // buttonOpenCheckinStream
            // 
            this.buttonOpenCheckinStream.Location = new System.Drawing.Point(219, 115);
            this.buttonOpenCheckinStream.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenCheckinStream.Name = "buttonOpenCheckinStream";
            this.buttonOpenCheckinStream.Size = new System.Drawing.Size(100, 34);
            this.buttonOpenCheckinStream.TabIndex = 21;
            this.buttonOpenCheckinStream.Text = "Stream";
            this.buttonOpenCheckinStream.UseVisualStyleBackColor = true;
            // 
            // buttonOpenCheckoutStream
            // 
            this.buttonOpenCheckoutStream.Location = new System.Drawing.Point(621, 112);
            this.buttonOpenCheckoutStream.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenCheckoutStream.Name = "buttonOpenCheckoutStream";
            this.buttonOpenCheckoutStream.Size = new System.Drawing.Size(100, 34);
            this.buttonOpenCheckoutStream.TabIndex = 22;
            this.buttonOpenCheckoutStream.Text = "Stream";
            this.buttonOpenCheckoutStream.UseVisualStyleBackColor = true;
            // 
            // comboBoxListWebcamCheckout
            // 
            this.comboBoxListWebcamCheckout.FormattingEnabled = true;
            this.comboBoxListWebcamCheckout.Location = new System.Drawing.Point(507, 118);
            this.comboBoxListWebcamCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxListWebcamCheckout.Name = "comboBoxListWebcamCheckout";
            this.comboBoxListWebcamCheckout.Size = new System.Drawing.Size(107, 24);
            this.comboBoxListWebcamCheckout.TabIndex = 23;
            this.comboBoxListWebcamCheckout.SelectedIndexChanged += new System.EventHandler(this.comboBoxListWebcamCheckout_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 639);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Plate Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(507, 659);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 25;
            // 
            // buttonCaptureCheckout
            // 
            this.buttonCaptureCheckout.Location = new System.Drawing.Point(399, 656);
            this.buttonCaptureCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCaptureCheckout.Name = "buttonCaptureCheckout";
            this.buttonCaptureCheckout.Size = new System.Drawing.Size(100, 28);
            this.buttonCaptureCheckout.TabIndex = 24;
            this.buttonCaptureCheckout.Text = "Capture";
            this.buttonCaptureCheckout.UseVisualStyleBackColor = true;
            // 
            // buttonTestCapture
            // 
            this.buttonTestCapture.Location = new System.Drawing.Point(11, 692);
            this.buttonTestCapture.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTestCapture.Name = "buttonTestCapture";
            this.buttonTestCapture.Size = new System.Drawing.Size(100, 28);
            this.buttonTestCapture.TabIndex = 27;
            this.buttonTestCapture.Text = "Test Capture";
            this.buttonTestCapture.UseVisualStyleBackColor = true;
            this.buttonTestCapture.Click += new System.EventHandler(this.buttonTestCapture_Click);
            // 
            // textBoxCardId
            // 
            this.textBoxCardId.Location = new System.Drawing.Point(106, 88);
            this.textBoxCardId.Name = "textBoxCardId";
            this.textBoxCardId.Size = new System.Drawing.Size(107, 22);
            this.textBoxCardId.TabIndex = 28;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 750);
            this.Controls.Add(this.textBoxCardId);
            this.Controls.Add(this.buttonTestCapture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCaptureCheckout);
            this.Controls.Add(this.comboBoxListWebcamCheckout);
            this.Controls.Add(this.buttonOpenCheckoutStream);
            this.Controls.Add(this.buttonOpenCheckinStream);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCheckin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBoxWebcamCheckout);
            this.Controls.Add(this.pictureBoxWebcamCheckin);
            this.Controls.Add(this.comboBoxListWebcamCheckin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plateResult);
            this.Controls.Add(this.pictureBoxPlateImageCheckout);
            this.Controls.Add(this.pictureBoxSelectedImageCheckin);
            this.Controls.Add(this.buttonCaptureCheckin);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImageCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlateImageCheckout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcamCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcamCheckout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCaptureCheckin;
        private System.Windows.Forms.PictureBox pictureBoxSelectedImageCheckin;
        private System.Windows.Forms.PictureBox pictureBoxPlateImageCheckout;
        private System.Windows.Forms.TextBox plateResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxListWebcamCheckin;
        private System.Windows.Forms.PictureBox pictureBoxWebcamCheckin;
        private System.Windows.Forms.PictureBox pictureBoxWebcamCheckout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCheckin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOpenCheckinStream;
        private System.Windows.Forms.Button buttonOpenCheckoutStream;
        private System.Windows.Forms.ComboBox comboBoxListWebcamCheckout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCaptureCheckout;
        private System.Windows.Forms.Button buttonTestCapture;
        private System.Windows.Forms.TextBox textBoxCardId;
    }
}

