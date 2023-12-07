namespace WindowsFormsApp1.form
{
    partial class ParkingManageForm
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
            this.dataGridViewListLog = new System.Windows.Forms.DataGridView();
            this.buttonCheckin = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListLog
            // 
            this.dataGridViewListLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewListLog.Location = new System.Drawing.Point(0, 190);
            this.dataGridViewListLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewListLog.Name = "dataGridViewListLog";
            this.dataGridViewListLog.RowHeadersWidth = 51;
            this.dataGridViewListLog.Size = new System.Drawing.Size(644, 185);
            this.dataGridViewListLog.TabIndex = 0;
            // 
            // buttonCheckin
            // 
            this.buttonCheckin.Location = new System.Drawing.Point(44, 26);
            this.buttonCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCheckin.Name = "buttonCheckin";
            this.buttonCheckin.Size = new System.Drawing.Size(100, 54);
            this.buttonCheckin.TabIndex = 1;
            this.buttonCheckin.Text = "Checkin";
            this.buttonCheckin.UseVisualStyleBackColor = true;
            this.buttonCheckin.Click += new System.EventHandler(this.buttonCheckin_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(44, 100);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(100, 52);
            this.buttonCheckout.TabIndex = 2;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // ParkingManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 375);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonCheckin);
            this.Controls.Add(this.dataGridViewListLog);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ParkingManageForm";
            this.Text = "Parking Management";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ParkingManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListLog;
        private System.Windows.Forms.Button buttonCheckin;
        private System.Windows.Forms.Button buttonCheckout;
    }
}