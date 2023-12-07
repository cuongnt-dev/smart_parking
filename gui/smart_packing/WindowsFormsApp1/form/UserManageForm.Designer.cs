namespace WindowsFormsApp1
{
    partial class UserManageForm
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
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.groupBoxSelectedUser = new System.Windows.Forms.GroupBox();
            this.buttonExportQRCode = new System.Windows.Forms.Button();
            this.labelSelectedUser = new System.Windows.Forms.Label();
            this.buttonDeleteSelectedUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.groupBoxSelectedUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(21, 26);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(85, 47);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewUser.Location = new System.Drawing.Point(0, 166);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUser.Size = new System.Drawing.Size(905, 388);
            this.dataGridViewUser.TabIndex = 1;
            this.dataGridViewUser.SelectionChanged += new System.EventHandler(this.dataGridViewUser_SelectionChanged);
            // 
            // groupBoxSelectedUser
            // 
            this.groupBoxSelectedUser.Controls.Add(this.buttonExportQRCode);
            this.groupBoxSelectedUser.Controls.Add(this.labelSelectedUser);
            this.groupBoxSelectedUser.Controls.Add(this.buttonDeleteSelectedUser);
            this.groupBoxSelectedUser.Location = new System.Drawing.Point(623, 15);
            this.groupBoxSelectedUser.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSelectedUser.Name = "groupBoxSelectedUser";
            this.groupBoxSelectedUser.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSelectedUser.Size = new System.Drawing.Size(267, 123);
            this.groupBoxSelectedUser.TabIndex = 2;
            this.groupBoxSelectedUser.TabStop = false;
            this.groupBoxSelectedUser.Text = "Selected User";
            // 
            // buttonExportQRCode
            // 
            this.buttonExportQRCode.Location = new System.Drawing.Point(24, 73);
            this.buttonExportQRCode.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExportQRCode.Name = "buttonExportQRCode";
            this.buttonExportQRCode.Size = new System.Drawing.Size(104, 42);
            this.buttonExportQRCode.TabIndex = 2;
            this.buttonExportQRCode.Text = "Export QRCode";
            this.buttonExportQRCode.UseVisualStyleBackColor = true;
            this.buttonExportQRCode.Click += new System.EventHandler(this.buttonExportQRCode_Click);
            // 
            // labelSelectedUser
            // 
            this.labelSelectedUser.AutoSize = true;
            this.labelSelectedUser.Location = new System.Drawing.Point(21, 27);
            this.labelSelectedUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectedUser.Name = "labelSelectedUser";
            this.labelSelectedUser.Size = new System.Drawing.Size(0, 16);
            this.labelSelectedUser.TabIndex = 1;
            // 
            // buttonDeleteSelectedUser
            // 
            this.buttonDeleteSelectedUser.Location = new System.Drawing.Point(147, 73);
            this.buttonDeleteSelectedUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteSelectedUser.Name = "buttonDeleteSelectedUser";
            this.buttonDeleteSelectedUser.Size = new System.Drawing.Size(112, 42);
            this.buttonDeleteSelectedUser.TabIndex = 0;
            this.buttonDeleteSelectedUser.Text = "Delete";
            this.buttonDeleteSelectedUser.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedUser.Click += new System.EventHandler(this.buttonDeleteSelectedUser_Click);
            // 
            // UserManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 554);
            this.Controls.Add(this.groupBoxSelectedUser);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.buttonAddUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManageForm";
            this.Text = "User Management";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.groupBoxSelectedUser.ResumeLayout(false);
            this.groupBoxSelectedUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.GroupBox groupBoxSelectedUser;
        private System.Windows.Forms.Label labelSelectedUser;
        private System.Windows.Forms.Button buttonDeleteSelectedUser;
        private System.Windows.Forms.Button buttonExportQRCode;
    }
}