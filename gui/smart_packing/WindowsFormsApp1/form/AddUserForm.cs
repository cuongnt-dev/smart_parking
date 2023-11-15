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

namespace WindowsFormsApp1.form
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            User usr = new User
            {
                Name = textBoxUserName.Text,
                Company = textBoxCompanyName.Text,
                ParkingCardId = textBoxCardID.Text,
                Role = "User",
            };
            try
            {
                DB.AddUser(usr);
            } catch (Exception ex)
            {
                MessageBox.Show($"Create User fail {ex.Message}");
            } finally
            {
                this.Hide();
            }
            
        }
    }
}
