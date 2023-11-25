using AForge.Video.DirectShow;
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

namespace WindowsFormsApp1.form
{
    public partial class SystemManageForm : Form
    {
        private FilterInfoCollection listWebcamInfo;
        private List<string> barierState = new List<string>{Constant.CHECKIN_STATE, Constant.CHECKOUT_STATE};
        public SystemManageForm()
        {
            InitializeComponent();
        }

        private void SystemManageForm_Load(object sender, EventArgs e)
        {
            listWebcamInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in listWebcamInfo)
            {
                comboBoxCheckinCam.Items.Add(item.Name);
                comboBoxCheckoutCam.Items.Add(item.Name);
            }
            foreach (string state in barierState)
            {
                comboBoxBarier1.Items.Add(state);
                comboBoxBarier2.Items.Add(state);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCheckinCam.SelectedItem != null)
                {
                    string checkinCam = comboBoxCheckinCam.SelectedItem.ToString();
                    DB.UpsertSetting(Constant.CHECKIN_CAM, checkinCam);
                }
                if (comboBoxCheckoutCam.SelectedItem != null)
                {
                    string checkoutCam = comboBoxCheckoutCam.SelectedItem.ToString();
                    DB.UpsertSetting(Constant.CHECKOUT_CAM, checkoutCam);
                }
                if (comboBoxBarier1.SelectedItem != null)
                {
                    string barier1 = comboBoxBarier1.SelectedItem.ToString();
                    DB.UpsertSetting(Constant.BARIER_1, barier1);
                }
                if (comboBoxBarier2.SelectedItem != null)
                {
                    string barier2 = comboBoxBarier2.SelectedItem.ToString();
                    DB.UpsertSetting(Constant.BARIER_2, barier2);
                }
                this.Close();
            } catch(Exception ex)
            {
                MessageBox.Show($"Config successfully {ex}");
            }
        }

        private void comboBoxBarier1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
