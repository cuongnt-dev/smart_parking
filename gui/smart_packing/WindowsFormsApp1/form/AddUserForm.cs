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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string companyName = textBoxCompanyName.Text;
            string cardId = textBoxCardId.Text;
            string role = comboBoxRole.SelectedItem.ToString();
            User usr = new User
            {
                Name = userName,
                Company = companyName,
                ParkingCardId = cardId,
                Role = role

            };
            DB.AddUser(usr)
        }
    }
}
