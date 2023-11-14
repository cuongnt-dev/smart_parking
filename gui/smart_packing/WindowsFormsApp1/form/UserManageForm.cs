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
            users = DB.GetUserWithCondition("");
            dataGridViewUser.DataSource = users;
            dataGridViewUser.Columns["Password"].Visible = false;
            dataGridViewUser.Columns["Plate"].Visible = false;
        }
    }
}
