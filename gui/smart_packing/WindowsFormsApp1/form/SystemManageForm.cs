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
        private Dictionary<string, ComboBox> entranceCamSettingList = new Dictionary<string, ComboBox> {};
        private Dictionary<string, ComboBox> entranceStateSettingList = new Dictionary<string, ComboBox> { };

        public SystemManageForm()
        {
            InitializeComponent();
            entranceCamSettingList.Add(Constant.ENTRANCE_1_CAM_IN, comboBoxEntrance1CamIn);
            entranceCamSettingList.Add(Constant.ENTRANCE_1_CAM_OUT, comboBoxEntrance1CamOut);
            entranceCamSettingList.Add(Constant.ENTRANCE_2_CAM_IN, comboBoxEntrance2CamIn);
            entranceCamSettingList.Add(Constant.ENTRANCE_2_CAM_OUT, comboBoxEntrance2CamOut);

            entranceStateSettingList.Add(Constant.ENTRANCE_1, comboBoxEntranceState1);
            entranceStateSettingList.Add(Constant.ENTRANCE_2, comboBoxEntranceState2);
        }

        private void SystemManageForm_Load(object sender, EventArgs e)
        {
            comboBoxEntranceState1.SelectedIndexChanged -= comboBoxEntranceState1_SelectedIndexChanged;
            comboBoxEntranceState2.SelectedIndexChanged -= comboBoxEntranceState2_SelectedIndexChanged;
            listWebcamInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (var camSettingItem in entranceCamSettingList)
            {
                camSettingItem.Value.Items.Add("-");
                foreach (FilterInfo item in listWebcamInfo)
                {
                    camSettingItem.Value.Items.Add(item.Name);
                }
            }

            foreach (var entranceSettingItem in entranceStateSettingList)
            {
                foreach (string state in barierState)
                {
                    entranceSettingItem.Value.Items.Add(state);
                }
            }
            
            List<Setting> settingsList = DB.GetAllSetting();
            if(settingsList != null)
            {
                foreach (var camSettingItem in entranceCamSettingList)
                {
                    Setting st = settingsList.FirstOrDefault(setting => setting.Name == camSettingItem.Key);
                    if (st != null)
                    {
                        camSettingItem.Value.SelectedItem = st.Value;
                    }
                }

                foreach (var entranceSettingItem in entranceStateSettingList)
                {
                    Setting st = settingsList.FirstOrDefault(setting => setting.Name == entranceSettingItem.Key);
                    if (st != null)
                    {
                        entranceSettingItem.Value.SelectedItem = st.Value;
                    }
                }
            }
            comboBoxEntranceState1.SelectedIndexChanged += comboBoxEntranceState1_SelectedIndexChanged;
            comboBoxEntranceState2.SelectedIndexChanged += comboBoxEntranceState2_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var camSettingItem in entranceCamSettingList)
                {
                    if (camSettingItem.Value.SelectedItem != null)
                    {
                        string value = camSettingItem.Value.SelectedItem.ToString();
                        value = value == "-" ? "" : value;
                        DB.UpsertSetting(camSettingItem.Key, value);
                    }
                }

                foreach (var entranceSettingItem in entranceStateSettingList)
                {
                    string state = entranceSettingItem.Value.SelectedItem.ToString();
                    DB.UpsertSetting(entranceSettingItem.Key, state);
                }
                ReloadMainForm.Invoke(this, null);
                this.Close();
            } catch(Exception ex)
            {
                MessageBox.Show($"Config successfully {ex}");
            }
        }
        private void comboBoxEntranceState1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Entrance 1 changed");
            string tempItemCbIn = "-";
            if(comboBoxEntrance1CamIn.SelectedItem != null)
            {
                tempItemCbIn = comboBoxEntrance1CamIn.SelectedItem.ToString();
            }
            string tempItemCbOut = "-";
            if (comboBoxEntrance1CamOut.SelectedItem != null)
            {
                tempItemCbOut = comboBoxEntrance1CamOut.SelectedItem.ToString();
            }
            comboBoxEntrance1CamIn.SelectedItem = tempItemCbOut;
            comboBoxEntrance1CamOut.SelectedItem = tempItemCbIn;
        }

        private void comboBoxEntranceState2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Entrance 2 changed");
            string tempItemCbIn = "-";
            if (comboBoxEntrance2CamIn.SelectedItem != null)
            {
                tempItemCbIn = comboBoxEntrance2CamIn.SelectedItem.ToString();
            }
            string tempItemCbOut = "-";
            if (comboBoxEntrance2CamOut.SelectedItem != null)
            {
                tempItemCbOut = comboBoxEntrance2CamOut.SelectedItem.ToString();
            }
            comboBoxEntrance2CamIn.SelectedItem = tempItemCbOut;
            comboBoxEntrance2CamOut.SelectedItem = tempItemCbIn;
        }
    }
}
