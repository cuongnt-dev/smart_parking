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
using WindowsFormsApp1.utils;

namespace WindowsFormsApp1
{
    public partial class AuthenicationForm : Form
    {
        private string authenticationFor;
        public event EventHandler LoadMainForm;
        public AuthenicationForm(string authFor)
        {
            InitializeComponent();
            authenticationFor = authFor;
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
            if(authenticationFor == "UserManageForm")
            {
                UserManageForm form = new UserManageForm(usrs[0]);
                form.Show();
            } else if(authenticationFor == "ParkingManageForm")
            {
                ParkingManageForm form = new ParkingManageForm();
                form.Show();
            }
            else if (authenticationFor == "SystemManageForm")
            {
                SystemManageForm form = new SystemManageForm();
                form.ReloadMainForm += LoadMainForm;
                form.Show();
            }
            this.Hide();
        }

        private void AuthenicationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
