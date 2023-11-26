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
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp1.form
{
    public partial class SystemManageForm : Form
    {
        private FilterInfoCollection listWebcamInfo;
        public event EventHandler ReloadMainForm;

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
                comboBoxEntranceCam1.Items.Add(item.Name);
                comboBoxEntranceCam2.Items.Add(item.Name);
            }
            foreach (string state in barierState)
            {
                comboBoxEntranceState1.Items.Add(state);
                comboBoxEntranceState2.Items.Add(state);
            }
            List<Setting> settingsList = DB.GetAllSetting();
            Setting cam1 = settingsList.FirstOrDefault(setting => setting.Name == Constant.ENTRANCE_CAM_1);
            if (cam1 != null)
            {
                comboBoxEntranceCam1.SelectedItem = cam1.Value;
            }
            Setting cam2 = settingsList.FirstOrDefault(setting => setting.Name == Constant.ENTRANCE_CAM_2);
            if (cam2 != null)
            {
                comboBoxEntranceCam2.SelectedItem = cam2.Value;
            }
            Setting entrance1 = settingsList.FirstOrDefault(setting => setting.Name == Constant.ENTRANCE_1);
            if (entrance1 != null)
            {
                comboBoxEntranceState1.SelectedItem = entrance1.Value;
            }
            Setting entrance2 = settingsList.FirstOrDefault(setting => setting.Name == Constant.ENTRANCE_2);
            if (entrance2 != null)
            {
                comboBoxEntranceState2.SelectedItem = entrance2.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEntranceCam1.SelectedItem != null)
                {
                    string checkinCam = comboBoxEntranceCam1.SelectedItem.ToString();
                    DB.UpsertSetting(Constant.ENTRANCE_CAM_1, checkinCam);
                }
                if (comboBoxEntranceCam2.SelectedItem != null)
                {
                    string checkoutCam = comboBoxEntranceCam2.SelectedItem.ToString();
                    DB.UpsertSetting(Constant.ENTRANCE_CAM_2, checkoutCam);
                }
                if (comboBoxEntranceState1.SelectedItem != null)
                {
                    string state = comboBoxEntranceState1.SelectedItem.ToString();
                    DB.UpsertSetting(Constant.ENTRANCE_1, state);
                }
                if (comboBoxEntranceState2.SelectedItem != null)
                {
                    string state = comboBoxEntranceState2.SelectedItem.ToString();
                    DB.UpsertSetting(Constant.ENTRANCE_2, state);
                }
                ReloadMainForm.Invoke(this, null);
                this.Close();
            } catch(Exception ex)
            {
                MessageBox.Show($"Config successfully {ex}");
            }
        }

    }
}
