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
            this.labelEntranceState1 = new System.Windows.Forms.Label();
            this.labelEntranceState2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCaptureCheckout = new System.Windows.Forms.Button();
            this.buttonTestCapture = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxCheckin = new System.Windows.Forms.GroupBox();
            this.buttonCloseBarier1 = new System.Windows.Forms.Button();
            this.labelCheckinBarierStatus = new System.Windows.Forms.Label();
            this.buttonOpenBarier1 = new System.Windows.Forms.Button();
            this.labelBarierState1 = new System.Windows.Forms.Label();
            this.statusIndicatorBarier1 = new WindowsFormsApp1.StatusIndicator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCloseBarier2 = new System.Windows.Forms.Button();
            this.buttonOpenBarier2 = new System.Windows.Forms.Button();
            this.labelBarierState2 = new System.Windows.Forms.Label();
            this.statusIndicatorBarier2 = new WindowsFormsApp1.StatusIndicator();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timerListenBarierState = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImageCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlateImageCheckout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcamCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcamCheckout)).BeginInit();
            this.groupBoxCheckin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCaptureCheckin
            // 
            this.buttonCaptureCheckin.Location = new System.Drawing.Point(16, 747);
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
            this.pictureBoxSelectedImageCheckin.Location = new System.Drawing.Point(3, 307);
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
            this.pictureBoxPlateImageCheckout.Location = new System.Drawing.Point(18, 309);
            this.pictureBoxPlateImageCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPlateImageCheckout.Name = "pictureBoxPlateImageCheckout";
            this.pictureBoxPlateImageCheckout.Size = new System.Drawing.Size(376, 165);
            this.pictureBoxPlateImageCheckout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlateImageCheckout.TabIndex = 6;
            this.pictureBoxPlateImageCheckout.TabStop = false;
            // 
            // plateResult
            // 
            this.plateResult.Location = new System.Drawing.Point(124, 750);
            this.plateResult.Margin = new System.Windows.Forms.Padding(4);
            this.plateResult.Name = "plateResult";
            this.plateResult.Size = new System.Drawing.Size(185, 22);
            this.plateResult.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 729);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plate Number";
            // 
            // pictureBoxWebcamCheckin
            // 
            this.pictureBoxWebcamCheckin.Location = new System.Drawing.Point(8, 51);
            this.pictureBoxWebcamCheckin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxWebcamCheckin.Name = "pictureBoxWebcamCheckin";
            this.pictureBoxWebcamCheckin.Size = new System.Drawing.Size(357, 250);
            this.pictureBoxWebcamCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWebcamCheckin.TabIndex = 12;
            this.pictureBoxWebcamCheckin.TabStop = false;
            // 
            // pictureBoxWebcamCheckout
            // 
            this.pictureBoxWebcamCheckout.Location = new System.Drawing.Point(18, 51);
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
            this.button4.Location = new System.Drawing.Point(168, 15);
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
            // labelEntranceState1
            // 
            this.labelEntranceState1.AutoSize = true;
            this.labelEntranceState1.Location = new System.Drawing.Point(5, 24);
            this.labelEntranceState1.Name = "labelEntranceState1";
            this.labelEntranceState1.Size = new System.Drawing.Size(102, 16);
            this.labelEntranceState1.TabIndex = 19;
            this.labelEntranceState1.Text = "State: Loading...";
            // 
            // labelEntranceState2
            // 
            this.labelEntranceState2.AutoSize = true;
            this.labelEntranceState2.Location = new System.Drawing.Point(19, 21);
            this.labelEntranceState2.Name = "labelEntranceState2";
            this.labelEntranceState2.Size = new System.Drawing.Size(102, 16);
            this.labelEntranceState2.TabIndex = 20;
            this.labelEntranceState2.Text = "State: Loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 729);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Plate Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(588, 753);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 22);
            this.textBox1.TabIndex = 25;
            // 
            // buttonCaptureCheckout
            // 
            this.buttonCaptureCheckout.Location = new System.Drawing.Point(444, 747);
            this.buttonCaptureCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCaptureCheckout.Name = "buttonCaptureCheckout";
            this.buttonCaptureCheckout.Size = new System.Drawing.Size(131, 35);
            this.buttonCaptureCheckout.TabIndex = 24;
            this.buttonCaptureCheckout.Text = "Capture";
            this.buttonCaptureCheckout.UseVisualStyleBackColor = true;
            // 
            // buttonTestCapture
            // 
            this.buttonTestCapture.Location = new System.Drawing.Point(16, 783);
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
            this.groupBoxCheckin.Controls.Add(this.buttonCloseBarier1);
            this.groupBoxCheckin.Controls.Add(this.labelCheckinBarierStatus);
            this.groupBoxCheckin.Controls.Add(this.buttonOpenBarier1);
            this.groupBoxCheckin.Controls.Add(this.labelBarierState1);
            this.groupBoxCheckin.Controls.Add(this.statusIndicatorBarier1);
            this.groupBoxCheckin.Location = new System.Drawing.Point(11, 617);
            this.groupBoxCheckin.Name = "groupBoxCheckin";
            this.groupBoxCheckin.Size = new System.Drawing.Size(380, 93);
            this.groupBoxCheckin.TabIndex = 29;
            this.groupBoxCheckin.TabStop = false;
            this.groupBoxCheckin.Text = "Barier Control";
            // 
            // buttonCloseBarier1
            // 
            this.buttonCloseBarier1.Location = new System.Drawing.Point(253, 26);
            this.buttonCloseBarier1.Name = "buttonCloseBarier1";
            this.buttonCloseBarier1.Size = new System.Drawing.Size(77, 36);
            this.buttonCloseBarier1.TabIndex = 4;
            this.buttonCloseBarier1.Text = "Close";
            this.buttonCloseBarier1.UseVisualStyleBackColor = true;
            this.buttonCloseBarier1.Click += new System.EventHandler(this.buttonCloseCheckinBarier_Click);
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
            // buttonOpenBarier1
            // 
            this.buttonOpenBarier1.Location = new System.Drawing.Point(157, 26);
            this.buttonOpenBarier1.Name = "buttonOpenBarier1";
            this.buttonOpenBarier1.Size = new System.Drawing.Size(77, 36);
            this.buttonOpenBarier1.TabIndex = 2;
            this.buttonOpenBarier1.Text = "Open";
            this.buttonOpenBarier1.UseVisualStyleBackColor = true;
            this.buttonOpenBarier1.Click += new System.EventHandler(this.buttonToggleCheckinBarier_Click_1);
            // 
            // labelBarierState1
            // 
            this.labelBarierState1.AutoSize = true;
            this.labelBarierState1.Location = new System.Drawing.Point(47, 46);
            this.labelBarierState1.Name = "labelBarierState1";
            this.labelBarierState1.Size = new System.Drawing.Size(42, 16);
            this.labelBarierState1.TabIndex = 1;
            this.labelBarierState1.Text = "Close";
            // 
            // statusIndicatorBarier1
            // 
            this.statusIndicatorBarier1.Location = new System.Drawing.Point(25, 45);
            this.statusIndicatorBarier1.Name = "statusIndicatorBarier1";
            this.statusIndicatorBarier1.Size = new System.Drawing.Size(16, 17);
            this.statusIndicatorBarier1.StatusColor = System.Drawing.Color.Red;
            this.statusIndicatorBarier1.TabIndex = 0;
            this.statusIndicatorBarier1.Text = "statusIndicator1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonCloseBarier2);
            this.groupBox1.Controls.Add(this.buttonOpenBarier2);
            this.groupBox1.Controls.Add(this.labelBarierState2);
            this.groupBox1.Controls.Add(this.statusIndicatorBarier2);
            this.groupBox1.Location = new System.Drawing.Point(426, 617);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 93);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barier Control";
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
            // buttonCloseBarier2
            // 
            this.buttonCloseBarier2.Location = new System.Drawing.Point(281, 26);
            this.buttonCloseBarier2.Name = "buttonCloseBarier2";
            this.buttonCloseBarier2.Size = new System.Drawing.Size(77, 36);
            this.buttonCloseBarier2.TabIndex = 5;
            this.buttonCloseBarier2.Text = "Close";
            this.buttonCloseBarier2.UseVisualStyleBackColor = true;
            this.buttonCloseBarier2.Click += new System.EventHandler(this.buttonCloseBarier2_Click);
            // 
            // buttonOpenBarier2
            // 
            this.buttonOpenBarier2.Location = new System.Drawing.Point(178, 28);
            this.buttonOpenBarier2.Name = "buttonOpenBarier2";
            this.buttonOpenBarier2.Size = new System.Drawing.Size(80, 34);
            this.buttonOpenBarier2.TabIndex = 2;
            this.buttonOpenBarier2.Text = "Open";
            this.buttonOpenBarier2.UseVisualStyleBackColor = true;
            this.buttonOpenBarier2.Click += new System.EventHandler(this.buttonOpenBarier2_Click);
            // 
            // labelBarierState2
            // 
            this.labelBarierState2.AutoSize = true;
            this.labelBarierState2.Location = new System.Drawing.Point(48, 45);
            this.labelBarierState2.Name = "labelBarierState2";
            this.labelBarierState2.Size = new System.Drawing.Size(42, 16);
            this.labelBarierState2.TabIndex = 1;
            this.labelBarierState2.Text = "Close";
            // 
            // statusIndicatorBarier2
            // 
            this.statusIndicatorBarier2.Location = new System.Drawing.Point(26, 45);
            this.statusIndicatorBarier2.Name = "statusIndicatorBarier2";
            this.statusIndicatorBarier2.Size = new System.Drawing.Size(16, 17);
            this.statusIndicatorBarier2.StatusColor = System.Drawing.Color.Red;
            this.statusIndicatorBarier2.TabIndex = 0;
            this.statusIndicatorBarier2.Text = "statusIndicator2";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(323, 15);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 68);
            this.button6.TabIndex = 31;
            this.button6.Text = "System Management";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(60, 850);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddress.TabIndex = 32;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(63, 909);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxValue.TabIndex = 33;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(206, 908);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 34;
            this.button7.Text = "Write";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(203, 849);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 35;
            this.button8.Text = "Read";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 828);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 890);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Value";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelEntranceState2);
            this.groupBox2.Controls.Add(this.pictureBoxWebcamCheckout);
            this.groupBox2.Controls.Add(this.pictureBoxPlateImageCheckout);
            this.groupBox2.Location = new System.Drawing.Point(426, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 489);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrance 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelEntranceState1);
            this.groupBox3.Controls.Add(this.pictureBoxWebcamCheckin);
            this.groupBox3.Controls.Add(this.pictureBoxSelectedImageCheckin);
            this.groupBox3.Location = new System.Drawing.Point(8, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 489);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Entrance 1";
            // 
            // timerListenBarierState
            // 
            this.timerListenBarierState.Enabled = true;
            this.timerListenBarierState.Interval = 2000;
            this.timerListenBarierState.Tick += new System.EventHandler(this.timerListenBarierState_Tick_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 962);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCheckin);
            this.Controls.Add(this.buttonTestCapture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCaptureCheckout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plateResult);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label labelEntranceState1;
        private System.Windows.Forms.Label labelEntranceState2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCaptureCheckout;
        private System.Windows.Forms.Button buttonTestCapture;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBoxCheckin;
        private StatusIndicator statusIndicatorBarier1;
        private System.Windows.Forms.Button buttonOpenBarier1;
        private System.Windows.Forms.Label labelBarierState1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOpenBarier2;
        private System.Windows.Forms.Label labelBarierState2;
        private StatusIndicator statusIndicatorBarier2;
        private System.Windows.Forms.Label labelCheckinBarierStatus;
        private System.Windows.Forms.Button buttonCloseBarier1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCloseBarier2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timerListenBarierState;
    }
}

