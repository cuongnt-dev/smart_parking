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
    public partial class ParkingManageForm : Form
    {
        private List<Log> logs;
        public ParkingManageForm()
        {
            InitializeComponent();
        }

        private void ParkingManageForm_Load(object sender, EventArgs e)
        {
            LoadLogList(this, null);
        }

        private void LoadLogList(object sender, Log log)
        {
            logs = DB.GetLogWithCondition("");
            dataGridViewListLog.DataSource = logs;
        }

        private void buttonCheckin_Click(object sender, EventArgs e)
        {
            string detectedPlate = "123456";
            string cardId = "123456";

            // Check right user
            List<User> usrs = DB.GetUserWithCondition($"parking_card_id='{cardId}' AND plate='{detectedPlate}'");
            if(usrs.Count == 0)
            {
                MessageBox.Show("Wrong detected information");
                return;
            }
            try
            {
                Log log = new Log
                {
                    Type = "Checkin",
                    Occurrence = DateTime.Now,
                    UserID = usrs[0].ID,
                };
                DB.CreateLog(log);
                LoadLogList(this, null);
            } catch(Exception ex)
            {
                MessageBox.Show($"Create checkin/checkout data fail {ex.Message}");
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            string detectedPlate = "123456";
            string cardId = "123456";
            List<User> usrs = DB.GetUserWithCondition($"parking_card_id='{cardId}' AND plate='{detectedPlate}'");
            if (usrs.Count == 0)
            {
                MessageBox.Show("Wrong detected information");
                return;
            }
            // Check the latest log - Is checkin out checkout
            Log log = DB.GetLatestLog(detectedPlate);
            if (log == null)
            {
                MessageBox.Show("Can't get checkin data");
                return;
            }
            try
            {
                Log l = new Log
                {
                    Type = "Checkin",
                    Occurrence = DateTime.Now,
                    UserID = usrs[0].ID,
                };
                DB.CreateLog(l);
                LoadLogList(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Create checkin/checkout data fail {ex.Message}");
            }
        }
    }
}
