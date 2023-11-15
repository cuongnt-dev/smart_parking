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
            this.buttonDeleteSelectedUser = new System.Windows.Forms.Button();
            this.labelSelectedUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.groupBoxSelectedUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(16, 21);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(64, 38);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewUser.Location = new System.Drawing.Point(0, 135);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUser.Size = new System.Drawing.Size(679, 315);
            this.dataGridViewUser.TabIndex = 1;
            this.dataGridViewUser.SelectionChanged += new System.EventHandler(this.dataGridViewUser_SelectionChanged);
            // 
            // groupBoxSelectedUser
            // 
            this.groupBoxSelectedUser.Controls.Add(this.labelSelectedUser);
            this.groupBoxSelectedUser.Controls.Add(this.buttonDeleteSelectedUser);
            this.groupBoxSelectedUser.Location = new System.Drawing.Point(467, 12);
            this.groupBoxSelectedUser.Name = "groupBoxSelectedUser";
            this.groupBoxSelectedUser.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSelectedUser.TabIndex = 2;
            this.groupBoxSelectedUser.TabStop = false;
            this.groupBoxSelectedUser.Text = "Selected User";
            // 
            // buttonDeleteSelectedUser
            // 
            this.buttonDeleteSelectedUser.Location = new System.Drawing.Point(19, 47);
            this.buttonDeleteSelectedUser.Name = "buttonDeleteSelectedUser";
            this.buttonDeleteSelectedUser.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteSelectedUser.TabIndex = 0;
            this.buttonDeleteSelectedUser.Text = "Delete";
            this.buttonDeleteSelectedUser.UseVisualStyleBackColor = true;
            // 
            // labelSelectedUser
            // 
            this.labelSelectedUser.AutoSize = true;
            this.labelSelectedUser.Location = new System.Drawing.Point(16, 22);
            this.labelSelectedUser.Name = "labelSelectedUser";
            this.labelSelectedUser.Size = new System.Drawing.Size(0, 13);
            this.labelSelectedUser.TabIndex = 1;
            // 
            // UserManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.groupBoxSelectedUser);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.buttonAddUser);
            this.Name = "UserManageForm";
            this.Text = "User Management";
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
    }
}