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
            this.textBoxPlateEntrance1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxCamEntrance1In = new System.Windows.Forms.PictureBox();
            this.pictureBoxCamEntrance2In = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelEntranceState1 = new System.Windows.Forms.Label();
            this.labelEntranceState2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlateEntrance2 = new System.Windows.Forms.TextBox();
            this.buttonCaptureCheckout = new System.Windows.Forms.Button();
            this.buttonTestCapture = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxCheckin = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.statusIndicatorEntrance1Barier2 = new WindowsFormsApp1.StatusIndicator();
            this.buttonCloseBarier1 = new System.Windows.Forms.Button();
            this.labelCheckinBarierStatus = new System.Windows.Forms.Label();
            this.buttonOpenBarier1 = new System.Windows.Forms.Button();
            this.labelBarierState1 = new System.Windows.Forms.Label();
            this.statusIndicatorEntrance1Barier1 = new WindowsFormsApp1.StatusIndicator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCloseBarier2 = new System.Windows.Forms.Button();
            this.buttonOpenBarier2 = new System.Windows.Forms.Button();
            this.labelBarierState2 = new System.Windows.Forms.Label();
            this.statusIndicatorEntrance2Barier1 = new WindowsFormsApp1.StatusIndicator();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCamEntrance2Out = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCamEntrance1Out = new System.Windows.Forms.PictureBox();
            this.timerListenBarierState = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumberCheckin = new System.Windows.Forms.Label();
            this.labelInforDatetime = new System.Windows.Forms.Label();
            this.timerInforDatetime = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelEntrance1User = new System.Windows.Forms.Label();
            this.labelEntrance1Occurence = new System.Windows.Forms.Label();
            this.labelEntrance1Type = new System.Windows.Forms.Label();
            this.labelEntrance1PlateNumber = new System.Windows.Forms.Label();
            this.labelEntrance1CardID = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelEntrance2User = new System.Windows.Forms.Label();
            this.labelEntrance2Occurence = new System.Windows.Forms.Label();
            this.labelEntrance2Type = new System.Windows.Forms.Label();
            this.labelEntrance2PlateNumber = new System.Windows.Forms.Label();
            this.labelEntrance2CardID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImageCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlateImageCheckout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamEntrance1In)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamEntrance2In)).BeginInit();
            this.groupBoxCheckin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamEntrance2Out)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamEntrance1Out)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCaptureCheckin
            // 
            this.buttonCaptureCheckin.Location = new System.Drawing.Point(16, 779);
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
            // textBoxPlateEntrance1
            // 
            this.textBoxPlateEntrance1.Location = new System.Drawing.Point(124, 782);
            this.textBoxPlateEntrance1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlateEntrance1.Name = "textBoxPlateEntrance1";
            this.textBoxPlateEntrance1.Size = new System.Drawing.Size(185, 22);
            this.textBoxPlateEntrance1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 761);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plate Number";
            // 
            // pictureBoxCamEntrance1In
            // 
            this.pictureBoxCamEntrance1In.Location = new System.Drawing.Point(8, 51);
            this.pictureBoxCamEntrance1In.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCamEntrance1In.Name = "pictureBoxCamEntrance1In";
            this.pictureBoxCamEntrance1In.Size = new System.Drawing.Size(357, 250);
            this.pictureBoxCamEntrance1In.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCamEntrance1In.TabIndex = 12;
            this.pictureBoxCamEntrance1In.TabStop = false;
            // 
            // pictureBoxCamEntrance2In
            // 
            this.pictureBoxCamEntrance2In.Location = new System.Drawing.Point(18, 51);
            this.pictureBoxCamEntrance2In.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCamEntrance2In.Name = "pictureBoxCamEntrance2In";
            this.pictureBoxCamEntrance2In.Size = new System.Drawing.Size(376, 250);
            this.pictureBoxCamEntrance2In.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCamEntrance2In.TabIndex = 14;
            this.pictureBoxCamEntrance2In.TabStop = false;
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
            this.button1.Location = new System.Drawing.Point(1514, 15);
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
            this.label2.Location = new System.Drawing.Point(395, 883);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Plate Number";
            // 
            // textBoxPlateEntrance2
            // 
            this.textBoxPlateEntrance2.Location = new System.Drawing.Point(540, 907);
            this.textBoxPlateEntrance2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlateEntrance2.Name = "textBoxPlateEntrance2";
            this.textBoxPlateEntrance2.Size = new System.Drawing.Size(200, 22);
            this.textBoxPlateEntrance2.TabIndex = 25;
            // 
            // buttonCaptureCheckout
            // 
            this.buttonCaptureCheckout.Location = new System.Drawing.Point(396, 901);
            this.buttonCaptureCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCaptureCheckout.Name = "buttonCaptureCheckout";
            this.buttonCaptureCheckout.Size = new System.Drawing.Size(131, 35);
            this.buttonCaptureCheckout.TabIndex = 24;
            this.buttonCaptureCheckout.Text = "Capture";
            this.buttonCaptureCheckout.UseVisualStyleBackColor = true;
            // 
            // buttonTestCapture
            // 
            this.buttonTestCapture.Location = new System.Drawing.Point(19, 826);
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
            this.groupBoxCheckin.Controls.Add(this.button2);
            this.groupBoxCheckin.Controls.Add(this.label10);
            this.groupBoxCheckin.Controls.Add(this.button5);
            this.groupBoxCheckin.Controls.Add(this.label11);
            this.groupBoxCheckin.Controls.Add(this.statusIndicatorEntrance1Barier2);
            this.groupBoxCheckin.Controls.Add(this.buttonCloseBarier1);
            this.groupBoxCheckin.Controls.Add(this.labelCheckinBarierStatus);
            this.groupBoxCheckin.Controls.Add(this.buttonOpenBarier1);
            this.groupBoxCheckin.Controls.Add(this.labelBarierState1);
            this.groupBoxCheckin.Controls.Add(this.statusIndicatorEntrance1Barier1);
            this.groupBoxCheckin.Location = new System.Drawing.Point(11, 617);
            this.groupBoxCheckin.Name = "groupBoxCheckin";
            this.groupBoxCheckin.Size = new System.Drawing.Size(372, 137);
            this.groupBoxCheckin.TabIndex = 29;
            this.groupBoxCheckin.TabStop = false;
            this.groupBoxCheckin.Text = "Barier Control";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Barier 2: Normal";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(157, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 36);
            this.button5.TabIndex = 7;
            this.button5.Text = "Open";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Close";
            // 
            // statusIndicatorEntrance1Barier2
            // 
            this.statusIndicatorEntrance1Barier2.Location = new System.Drawing.Point(25, 95);
            this.statusIndicatorEntrance1Barier2.Name = "statusIndicatorEntrance1Barier2";
            this.statusIndicatorEntrance1Barier2.Size = new System.Drawing.Size(16, 17);
            this.statusIndicatorEntrance1Barier2.StatusColor = System.Drawing.Color.Red;
            this.statusIndicatorEntrance1Barier2.TabIndex = 5;
            this.statusIndicatorEntrance1Barier2.Text = "statusIndicator1";
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
            // statusIndicatorEntrance1Barier1
            // 
            this.statusIndicatorEntrance1Barier1.Location = new System.Drawing.Point(25, 45);
            this.statusIndicatorEntrance1Barier1.Name = "statusIndicatorEntrance1Barier1";
            this.statusIndicatorEntrance1Barier1.Size = new System.Drawing.Size(16, 17);
            this.statusIndicatorEntrance1Barier1.StatusColor = System.Drawing.Color.Red;
            this.statusIndicatorEntrance1Barier1.TabIndex = 0;
            this.statusIndicatorEntrance1Barier1.Text = "statusIndicator1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonCloseBarier2);
            this.groupBox1.Controls.Add(this.buttonOpenBarier2);
            this.groupBox1.Controls.Add(this.labelBarierState2);
            this.groupBox1.Controls.Add(this.statusIndicatorEntrance2Barier1);
            this.groupBox1.Location = new System.Drawing.Point(811, 617);
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
            // statusIndicatorEntrance2Barier1
            // 
            this.statusIndicatorEntrance2Barier1.Location = new System.Drawing.Point(26, 45);
            this.statusIndicatorEntrance2Barier1.Name = "statusIndicatorEntrance2Barier1";
            this.statusIndicatorEntrance2Barier1.Size = new System.Drawing.Size(16, 17);
            this.statusIndicatorEntrance2Barier1.StatusColor = System.Drawing.Color.Red;
            this.statusIndicatorEntrance2Barier1.TabIndex = 0;
            this.statusIndicatorEntrance2Barier1.Text = "statusIndicator2";
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
            this.textBoxAddress.Location = new System.Drawing.Point(63, 861);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddress.TabIndex = 32;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(66, 920);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxValue.TabIndex = 33;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(209, 919);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 34;
            this.button7.Text = "Write";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(206, 860);
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
            this.label6.Location = new System.Drawing.Point(63, 871);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 901);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Value";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBoxCamEntrance2Out);
            this.groupBox2.Controls.Add(this.labelEntranceState2);
            this.groupBox2.Controls.Add(this.pictureBoxCamEntrance2In);
            this.groupBox2.Controls.Add(this.pictureBoxPlateImageCheckout);
            this.groupBox2.Location = new System.Drawing.Point(811, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 489);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrance 2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(415, 309);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(376, 165);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxCamEntrance2Out
            // 
            this.pictureBoxCamEntrance2Out.Location = new System.Drawing.Point(415, 51);
            this.pictureBoxCamEntrance2Out.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCamEntrance2Out.Name = "pictureBoxCamEntrance2Out";
            this.pictureBoxCamEntrance2Out.Size = new System.Drawing.Size(376, 250);
            this.pictureBoxCamEntrance2Out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCamEntrance2Out.TabIndex = 21;
            this.pictureBoxCamEntrance2Out.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBoxCamEntrance1Out);
            this.groupBox3.Controls.Add(this.labelEntranceState1);
            this.groupBox3.Controls.Add(this.pictureBoxCamEntrance1In);
            this.groupBox3.Controls.Add(this.pictureBoxSelectedImageCheckin);
            this.groupBox3.Location = new System.Drawing.Point(8, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 489);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Entrance 1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(388, 307);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(357, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxCamEntrance1Out
            // 
            this.pictureBoxCamEntrance1Out.Location = new System.Drawing.Point(388, 51);
            this.pictureBoxCamEntrance1Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCamEntrance1Out.Name = "pictureBoxCamEntrance1Out";
            this.pictureBoxCamEntrance1Out.Size = new System.Drawing.Size(357, 250);
            this.pictureBoxCamEntrance1Out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCamEntrance1Out.TabIndex = 20;
            this.pictureBoxCamEntrance1Out.TabStop = false;
            // 
            // timerListenBarierState
            // 
            this.timerListenBarierState.Enabled = true;
            this.timerListenBarierState.Interval = 2000;
            this.timerListenBarierState.Tick += new System.EventHandler(this.timerListenBarierState_Tick_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.labelNumberCheckin);
            this.groupBox4.Controls.Add(this.labelInforDatetime);
            this.groupBox4.Location = new System.Drawing.Point(833, 760);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 202);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parking Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Latest Checkout: Loading...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Latest Checkin: Loading...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Slot Avaiable: Loading...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number Checkout Today: Loading...";
            // 
            // labelNumberCheckin
            // 
            this.labelNumberCheckin.AutoSize = true;
            this.labelNumberCheckin.Location = new System.Drawing.Point(14, 138);
            this.labelNumberCheckin.Name = "labelNumberCheckin";
            this.labelNumberCheckin.Size = new System.Drawing.Size(213, 16);
            this.labelNumberCheckin.TabIndex = 1;
            this.labelNumberCheckin.Text = "Number Checkin Today: Loading...";
            // 
            // labelInforDatetime
            // 
            this.labelInforDatetime.AutoSize = true;
            this.labelInforDatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInforDatetime.Location = new System.Drawing.Point(15, 31);
            this.labelInforDatetime.Name = "labelInforDatetime";
            this.labelInforDatetime.Size = new System.Drawing.Size(125, 16);
            this.labelInforDatetime.TabIndex = 0;
            this.labelInforDatetime.Text = "Datetime: Loading...";
            // 
            // timerInforDatetime
            // 
            this.timerInforDatetime.Enabled = true;
            this.timerInforDatetime.Interval = 1000;
            this.timerInforDatetime.Tick += new System.EventHandler(this.timerInforDatetime_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelEntrance1User);
            this.groupBox5.Controls.Add(this.labelEntrance1Occurence);
            this.groupBox5.Controls.Add(this.labelEntrance1Type);
            this.groupBox5.Controls.Add(this.labelEntrance1PlateNumber);
            this.groupBox5.Controls.Add(this.labelEntrance1CardID);
            this.groupBox5.Location = new System.Drawing.Point(398, 617);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 174);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Last CheckIn/Out Information";
            // 
            // labelEntrance1User
            // 
            this.labelEntrance1User.AutoSize = true;
            this.labelEntrance1User.Location = new System.Drawing.Point(17, 86);
            this.labelEntrance1User.Name = "labelEntrance1User";
            this.labelEntrance1User.Size = new System.Drawing.Size(42, 16);
            this.labelEntrance1User.TabIndex = 4;
            this.labelEntrance1User.Text = "User: ";
            // 
            // labelEntrance1Occurence
            // 
            this.labelEntrance1Occurence.AutoSize = true;
            this.labelEntrance1Occurence.Location = new System.Drawing.Point(17, 143);
            this.labelEntrance1Occurence.Name = "labelEntrance1Occurence";
            this.labelEntrance1Occurence.Size = new System.Drawing.Size(78, 16);
            this.labelEntrance1Occurence.TabIndex = 3;
            this.labelEntrance1Occurence.Text = "Occurance: ";
            // 
            // labelEntrance1Type
            // 
            this.labelEntrance1Type.AutoSize = true;
            this.labelEntrance1Type.Location = new System.Drawing.Point(17, 112);
            this.labelEntrance1Type.Name = "labelEntrance1Type";
            this.labelEntrance1Type.Size = new System.Drawing.Size(45, 16);
            this.labelEntrance1Type.TabIndex = 2;
            this.labelEntrance1Type.Text = "Type: ";
            // 
            // labelEntrance1PlateNumber
            // 
            this.labelEntrance1PlateNumber.AutoSize = true;
            this.labelEntrance1PlateNumber.Location = new System.Drawing.Point(17, 56);
            this.labelEntrance1PlateNumber.Name = "labelEntrance1PlateNumber";
            this.labelEntrance1PlateNumber.Size = new System.Drawing.Size(95, 16);
            this.labelEntrance1PlateNumber.TabIndex = 1;
            this.labelEntrance1PlateNumber.Text = "Plate Number: ";
            // 
            // labelEntrance1CardID
            // 
            this.labelEntrance1CardID.AutoSize = true;
            this.labelEntrance1CardID.Location = new System.Drawing.Point(17, 28);
            this.labelEntrance1CardID.Name = "labelEntrance1CardID";
            this.labelEntrance1CardID.Size = new System.Drawing.Size(58, 16);
            this.labelEntrance1CardID.TabIndex = 0;
            this.labelEntrance1CardID.Text = "Card ID: ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelEntrance2User);
            this.groupBox6.Controls.Add(this.labelEntrance2Occurence);
            this.groupBox6.Controls.Add(this.labelEntrance2Type);
            this.groupBox6.Controls.Add(this.labelEntrance2PlateNumber);
            this.groupBox6.Controls.Add(this.labelEntrance2CardID);
            this.groupBox6.Location = new System.Drawing.Point(1232, 617);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(370, 197);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Last CheckIn/Out Information";
            // 
            // labelEntrance2User
            // 
            this.labelEntrance2User.AutoSize = true;
            this.labelEntrance2User.Location = new System.Drawing.Point(18, 95);
            this.labelEntrance2User.Name = "labelEntrance2User";
            this.labelEntrance2User.Size = new System.Drawing.Size(42, 16);
            this.labelEntrance2User.TabIndex = 9;
            this.labelEntrance2User.Text = "User: ";
            // 
            // labelEntrance2Occurence
            // 
            this.labelEntrance2Occurence.AutoSize = true;
            this.labelEntrance2Occurence.Location = new System.Drawing.Point(18, 152);
            this.labelEntrance2Occurence.Name = "labelEntrance2Occurence";
            this.labelEntrance2Occurence.Size = new System.Drawing.Size(78, 16);
            this.labelEntrance2Occurence.TabIndex = 8;
            this.labelEntrance2Occurence.Text = "Occurance: ";
            // 
            // labelEntrance2Type
            // 
            this.labelEntrance2Type.AutoSize = true;
            this.labelEntrance2Type.Location = new System.Drawing.Point(18, 121);
            this.labelEntrance2Type.Name = "labelEntrance2Type";
            this.labelEntrance2Type.Size = new System.Drawing.Size(45, 16);
            this.labelEntrance2Type.TabIndex = 7;
            this.labelEntrance2Type.Text = "Type: ";
            // 
            // labelEntrance2PlateNumber
            // 
            this.labelEntrance2PlateNumber.AutoSize = true;
            this.labelEntrance2PlateNumber.Location = new System.Drawing.Point(18, 65);
            this.labelEntrance2PlateNumber.Name = "labelEntrance2PlateNumber";
            this.labelEntrance2PlateNumber.Size = new System.Drawing.Size(95, 16);
            this.labelEntrance2PlateNumber.TabIndex = 6;
            this.labelEntrance2PlateNumber.Text = "Plate Number: ";
            // 
            // labelEntrance2CardID
            // 
            this.labelEntrance2CardID.AutoSize = true;
            this.labelEntrance2CardID.Location = new System.Drawing.Point(18, 37);
            this.labelEntrance2CardID.Name = "labelEntrance2CardID";
            this.labelEntrance2CardID.Size = new System.Drawing.Size(58, 16);
            this.labelEntrance2CardID.TabIndex = 5;
            this.labelEntrance2CardID.Text = "Card ID: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 1015);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
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
            this.Controls.Add(this.textBoxPlateEntrance2);
            this.Controls.Add(this.buttonCaptureCheckout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlateEntrance1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamEntrance1In)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamEntrance2In)).EndInit();
            this.groupBoxCheckin.ResumeLayout(false);
            this.groupBoxCheckin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamEntrance2Out)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamEntrance1Out)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCaptureCheckin;
        private System.Windows.Forms.PictureBox pictureBoxSelectedImageCheckin;
        private System.Windows.Forms.PictureBox pictureBoxPlateImageCheckout;
        private System.Windows.Forms.TextBox textBoxPlateEntrance1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCamEntrance1In;
        private System.Windows.Forms.PictureBox pictureBoxCamEntrance2In;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelEntranceState1;
        private System.Windows.Forms.Label labelEntranceState2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlateEntrance2;
        private System.Windows.Forms.Button buttonCaptureCheckout;
        private System.Windows.Forms.Button buttonTestCapture;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBoxCheckin;
        private StatusIndicator statusIndicatorEntrance1Barier1;
        private System.Windows.Forms.Button buttonOpenBarier1;
        private System.Windows.Forms.Label labelBarierState1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOpenBarier2;
        private System.Windows.Forms.Label labelBarierState2;
        private StatusIndicator statusIndicatorEntrance2Barier1;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelInforDatetime;
        private System.Windows.Forms.Timer timerInforDatetime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumberCheckin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxCamEntrance1Out;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxCamEntrance2Out;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelEntrance1User;
        private System.Windows.Forms.Label labelEntrance1Occurence;
        private System.Windows.Forms.Label labelEntrance1Type;
        private System.Windows.Forms.Label labelEntrance1PlateNumber;
        private System.Windows.Forms.Label labelEntrance1CardID;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelEntrance2User;
        private System.Windows.Forms.Label labelEntrance2Occurence;
        private System.Windows.Forms.Label labelEntrance2Type;
        private System.Windows.Forms.Label labelEntrance2PlateNumber;
        private System.Windows.Forms.Label labelEntrance2CardID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private StatusIndicator statusIndicatorEntrance1Barier2;
    }
}

