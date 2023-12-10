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
using ZXing.QrCode;
using ZXing;
using WindowsFormsApp1.utils;

namespace WindowsFormsApp1
{
    public partial class UserManageForm : Form
    {
        private User account;
        private List<User> users;
        private int selectedUserIndex;

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

        public static void ExportQRCode(string data, bool showMessageBox = true)
        {
            string hashedData = Hash.EncryptData(data);
            // Generate QR code
            Bitmap qrCode = GenerateQRCode(hashedData);

            // Save or display the QR code image as needed
            qrCode.Save($"{Constant.QR_PATH}\\{data}.png", System.Drawing.Imaging.ImageFormat.Png);
            if (showMessageBox)
            {
                MessageBox.Show($"QR Code exported successfully.", "QR Code Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static Bitmap GenerateQRCode(string data)
        {
            QrCodeEncodingOptions options = new QrCodeEncodingOptions()
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 500,
                Height = 500
            };

            BarcodeWriter writer = new BarcodeWriter()
            {
                Format = BarcodeFormat.QR_CODE,
                Options = options
            };
            Bitmap qrCodeBitmap = writer.Write(data);
            return qrCodeBitmap;
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
                selectedUserIndex = userId;
                dataGridViewUser.SelectionChanged += dataGridViewUser_SelectionChanged;
            } else
            {
                groupBoxSelectedUser.Visible = false;
            }
        }

        private void buttonDeleteSelectedUser_Click(object sender, EventArgs e)
        {
            try
            {
                DB.DeleteUserById(selectedUserIndex);
                MessageBox.Show("Delete User Successfully");
                LoadUserList(this, null);
            } catch(Exception ex)
            {
                MessageBox.Show($"Delete User fail {ex.Message}");
            }
        }

        private void buttonExportQRCode_Click(object sender, EventArgs e)
        {
            try
            {
                User usr = users.FirstOrDefault<User>(us => us.ID == selectedUserIndex);
                if(usr != null && usr.Card != "")
                {
                    string data = $"{usr.Card}_{Helper.GetCurrentDay()}";
                    ExportQRCode(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Export QR Code fail {ex.Message}");
            }
        }
    }
}
