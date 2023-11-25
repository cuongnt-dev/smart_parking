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
            this.components = new System.ComponentModel.Container();
            this.buttonCaptureCheckin = new System.Windows.Forms.Button();
            this.pictureBoxSelectedImageCheckin = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlateImageCheckout = new System.Windows.Forms.PictureBox();
            this.plateResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxWebcamCheckin = new System.Windows.Forms.PictureBox();
            this.pictureBoxWebcamCheckout = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCheckin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCaptureCheckout = new System.Windows.Forms.Button();
            this.buttonTestCapture = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxCheckin = new System.Windows.Forms.GroupBox();
            this.buttonCloseCheckinBarier = new System.Windows.Forms.Button();
            this.labelCheckinBarierStatus = new System.Windows.Forms.Label();
            this.buttonToggleCheckinBarier = new System.Windows.Forms.Button();
            this.labelCheckinBarier = new System.Windows.Forms.Label();
            this.statusIndicator = new WindowsFormsApp1.StatusIndicator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.statusIndicatorCheckout = new WindowsFormsApp1.StatusIndicator();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImageCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlateImageCheckout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcamCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcamCheckout)).BeginInit();
            this.groupBoxCheckin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCaptureCheckin
            // 
            this.buttonCaptureCheckin.Location = new System.Drawing.Point(10, 711);
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
            this.pictureBoxSelectedImageCheckin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSelectedImageCheckin.Location = new System.Drawing.Point(11, 409);
            this.pictureBoxSelectedImageCheckin.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSelectedImageCheckin.Name = "pictureBoxSelectedImageCheckin";
            this.pictureBoxSelectedImageCheckin.Size = new System.Drawing.Size(362, 165);
            this.pictureBoxSelectedImageCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedImageCheckin.TabIndex = 5;
            this.pictureBoxSelectedImageCheckin.TabStop = false;
            // 
            // pictureBoxPlateImageCheckout
            // 
            this.pictureBoxPlateImageCheckout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlateImageCheckout.Location = new System.Drawing.Point(444, 411);
            this.pictureBoxPlateImageCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPlateImageCheckout.Name = "pictureBoxPlateImageCheckout";
            this.pictureBoxPlateImageCheckout.Size = new System.Drawing.Size(376, 165);
            this.pictureBoxPlateImageCheckout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlateImageCheckout.TabIndex = 6;
            this.pictureBoxPlateImageCheckout.TabStop = false;
            // 
            // plateResult
            // 
            this.plateResult.Location = new System.Drawing.Point(118, 714);
            this.plateResult.Margin = new System.Windows.Forms.Padding(4);
            this.plateResult.Name = "plateResult";
            this.plateResult.Size = new System.Drawing.Size(185, 22);
            this.plateResult.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 694);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plate Number";
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
            this.pictureBoxWebcamCheckout.Location = new System.Drawing.Point(444, 153);
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
            this.button1.Location = new System.Drawing.Point(709, 15);
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
            this.label3.Location = new System.Drawing.Point(445, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Checkout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 694);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Plate Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(550, 717);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 25;
            // 
            // buttonCaptureCheckout
            // 
            this.buttonCaptureCheckout.Location = new System.Drawing.Point(442, 714);
            this.buttonCaptureCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCaptureCheckout.Name = "buttonCaptureCheckout";
            this.buttonCaptureCheckout.Size = new System.Drawing.Size(100, 28);
            this.buttonCaptureCheckout.TabIndex = 24;
            this.buttonCaptureCheckout.Text = "Capture";
            this.buttonCaptureCheckout.UseVisualStyleBackColor = true;
            // 
            // buttonTestCapture
            // 
            this.buttonTestCapture.Location = new System.Drawing.Point(10, 747);
            this.buttonTestCapture.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTestCapture.Name = "buttonTestCapture";
            this.buttonTestCapture.Size = new System.Drawing.Size(100, 28);
            this.buttonTestCapture.TabIndex = 27;
            this.buttonTestCapture.Text = "Test Capture";
            this.buttonTestCapture.UseVisualStyleBackColor = true;
            this.buttonTestCapture.Click += new System.EventHandler(this.buttonTestCapture_Click);
            // 
            // groupBoxCheckin
            // 
            this.groupBoxCheckin.Controls.Add(this.buttonCloseCheckinBarier);
            this.groupBoxCheckin.Controls.Add(this.labelCheckinBarierStatus);
            this.groupBoxCheckin.Controls.Add(this.buttonToggleCheckinBarier);
            this.groupBoxCheckin.Controls.Add(this.labelCheckinBarier);
            this.groupBoxCheckin.Controls.Add(this.statusIndicator);
            this.groupBoxCheckin.Location = new System.Drawing.Point(11, 591);
            this.groupBoxCheckin.Name = "groupBoxCheckin";
            this.groupBoxCheckin.Size = new System.Drawing.Size(362, 100);
            this.groupBoxCheckin.TabIndex = 29;
            this.groupBoxCheckin.TabStop = false;
            this.groupBoxCheckin.Text = "Checkin Barier";
            // 
            // buttonCloseCheckinBarier
            // 
            this.buttonCloseCheckinBarier.Location = new System.Drawing.Point(253, 26);
            this.buttonCloseCheckinBarier.Name = "buttonCloseCheckinBarier";
            this.buttonCloseCheckinBarier.Size = new System.Drawing.Size(77, 36);
            this.buttonCloseCheckinBarier.TabIndex = 4;
            this.buttonCloseCheckinBarier.Text = "Close";
            this.buttonCloseCheckinBarier.UseVisualStyleBackColor = true;
            this.buttonCloseCheckinBarier.Click += new System.EventHandler(this.buttonCloseCheckinBarier_Click);
            // 
            // labelCheckinBarierStatus
            // 
            this.labelCheckinBarierStatus.AutoSize = true;
            this.labelCheckinBarierStatus.Location = new System.Drawing.Point(22, 26);
            this.labelCheckinBarierStatus.Name = "labelCheckinBarierStatus";
            this.labelCheckinBarierStatus.Size = new System.Drawing.Size(103, 16);
            this.labelCheckinBarierStatus.TabIndex = 3;
            this.labelCheckinBarierStatus.Text = "Barier 1: Normal";
            // 
            // buttonToggleCheckinBarier
            // 
            this.buttonToggleCheckinBarier.Location = new System.Drawing.Point(157, 26);
            this.buttonToggleCheckinBarier.Name = "buttonToggleCheckinBarier";
            this.buttonToggleCheckinBarier.Size = new System.Drawing.Size(77, 36);
            this.buttonToggleCheckinBarier.TabIndex = 2;
            this.buttonToggleCheckinBarier.Text = "Open";
            this.buttonToggleCheckinBarier.UseVisualStyleBackColor = true;
            this.buttonToggleCheckinBarier.Click += new System.EventHandler(this.buttonToggleCheckinBarier_Click_1);
            // 
            // labelCheckinBarier
            // 
            this.labelCheckinBarier.AutoSize = true;
            this.labelCheckinBarier.Location = new System.Drawing.Point(47, 46);
            this.labelCheckinBarier.Name = "labelCheckinBarier";
            this.labelCheckinBarier.Size = new System.Drawing.Size(42, 16);
            this.labelCheckinBarier.TabIndex = 1;
            this.labelCheckinBarier.Text = "Close";
            // 
            // statusIndicator
            // 
            this.statusIndicator.Location = new System.Drawing.Point(25, 45);
            this.statusIndicator.Name = "statusIndicator";
            this.statusIndicator.Size = new System.Drawing.Size(16, 17);
            this.statusIndicator.StatusColor = System.Drawing.Color.Red;
            this.statusIndicator.TabIndex = 0;
            this.statusIndicator.Text = "statusIndicator1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.statusIndicatorCheckout);
            this.groupBox1.Location = new System.Drawing.Point(442, 591);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 86);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checkout Barier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Barier 2 Normal";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(281, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Close";
            // 
            // statusIndicatorCheckout
            // 
            this.statusIndicatorCheckout.Location = new System.Drawing.Point(26, 45);
            this.statusIndicatorCheckout.Name = "statusIndicatorCheckout";
            this.statusIndicatorCheckout.Size = new System.Drawing.Size(16, 17);
            this.statusIndicatorCheckout.StatusColor = System.Drawing.Color.Red;
            this.statusIndicatorCheckout.TabIndex = 0;
            this.statusIndicatorCheckout.Text = "statusIndicator2";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(326, 15);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 68);
            this.button6.TabIndex = 31;
            this.button6.Text = "System Management";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 833);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCheckin);
            this.Controls.Add(this.buttonTestCapture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCaptureCheckout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCheckin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBoxWebcamCheckout);
            this.Controls.Add(this.pictureBoxWebcamCheckin);
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
            this.groupBoxCheckin.ResumeLayout(false);
            this.groupBoxCheckin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCaptureCheckin;
        private System.Windows.Forms.PictureBox pictureBoxSelectedImageCheckin;
        private System.Windows.Forms.PictureBox pictureBoxPlateImageCheckout;
        private System.Windows.Forms.TextBox plateResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxWebcamCheckin;
        private System.Windows.Forms.PictureBox pictureBoxWebcamCheckout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCheckin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCaptureCheckout;
        private System.Windows.Forms.Button buttonTestCapture;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBoxCheckin;
        private StatusIndicator statusIndicator;
        private System.Windows.Forms.Button buttonToggleCheckinBarier;
        private System.Windows.Forms.Label labelCheckinBarier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private StatusIndicator statusIndicatorCheckout;
        private System.Windows.Forms.Label labelCheckinBarierStatus;
        private System.Windows.Forms.Button buttonCloseCheckinBarier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

