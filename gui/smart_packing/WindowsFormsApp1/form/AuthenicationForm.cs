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
using WindowsFormsApp1.utils;

namespace WindowsFormsApp1
{
    public partial class AuthenicationForm : Form
    {
        public AuthenicationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string hashPassword = Hash.HashString(password);
            List<User> usrs = DB.GetUserWithCondition($"name='{userName}' AND password='{hashPassword}' AND role='Admin'");
            if(usrs.Count == 0)
            {
                MessageBox.Show("Username Or Password wrong. Please try again");
                return;
            }
            UserManageForm manageForm = new UserManageForm(usrs[0]);
            manageForm.Show();
            this.Hide();
        }
    }
}
