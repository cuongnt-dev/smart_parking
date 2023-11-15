using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.database;
using WindowsFormsApp1.form;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1
{
    public partial class UserManageForm : Form
    {
        private User account;
        private List<User> users;

        public UserManageForm(User account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void UserManageForm_Load(object sender, EventArgs e)
        {
            LoadUserList(this, null);
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.LoadUserList += LoadUserList;
            addUserForm.ShowDialog();
        }

        private void LoadUserList(object sender, User usr)
        {
            users = DB.GetUserWithCondition("");
            dataGridViewUser.DataSource = users;
            dataGridViewUser.Columns["Password"].Visible = false;
            dataGridViewUser.Columns["Plate"].Visible = false;
        }

        private void dataGridViewUser_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridViewUser.SelectedRows.Count >= 1)
            {
                dataGridViewUser.SelectionChanged -= dataGridViewUser_SelectionChanged;
                groupBoxSelectedUser.Visible = true;
                DataGridViewRow latestSelectedRow = dataGridViewUser.SelectedRows[dataGridViewUser.SelectedRows.Count - 1];
                dataGridViewUser.ClearSelection();
                latestSelectedRow.Selected = true;
                int userId = Convert.ToInt32(latestSelectedRow.Cells[0].Value);  // Assumes ID is the first column
                string userName = Convert.ToString(latestSelectedRow.Cells[1].Value);  // Assumes Name is the second column
                string companyName = Convert.ToString(latestSelectedRow.Cells[2].Value); // Assumes Company is the third column
                labelSelectedUser.Text = $"{userId} - {userName} - {companyName}";
                dataGridViewUser.SelectionChanged += dataGridViewUser_SelectionChanged;
            } else
            {
                groupBoxSelectedUser.Visible = false;
            }
        }
    }
}
