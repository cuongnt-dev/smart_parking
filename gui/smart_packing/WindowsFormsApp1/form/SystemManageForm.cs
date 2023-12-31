﻿using AForge.Video.DirectShow;
using Microsoft.Scripting.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.database;
using WindowsFormsApp1.type;
using static System.Windows.Forms.AxHost;


namespace WindowsFormsApp1.form
{
    public partial class SystemManageForm : Form
    {
        public string controlModeStatus;
        private FilterInfoCollection listWebcamInfo;
        public event EventHandler ReloadMainForm;
        public event InternalEvent.UpdateControlModeDelegate UpdateControlMode;

        private List<string> barierState = new List<string>{Constant.CHECKIN_STATE, Constant.CHECKOUT_STATE};
        private List<string> controlMode = new List<string> { Constant.CONTROL_MODE_MANUAL, Constant.CONTROL_MODE_AUTOMATION };

        private Dictionary<string, ComboBox> entranceCamSettingList = new Dictionary<string, ComboBox> {};
        private Dictionary<string, ComboBox> entranceStateSettingList = new Dictionary<string, ComboBox> { };

        public SystemManageForm(string mode)
        {
            InitializeComponent();
            entranceCamSettingList.Add(Constant.ENTRANCE_1_CAM_IN, comboBoxEntrance1CamIn);
            entranceCamSettingList.Add(Constant.ENTRANCE_1_CAM_OUT, comboBoxEntrance1CamOut);
            entranceCamSettingList.Add(Constant.ENTRANCE_2_CAM_IN, comboBoxEntrance2CamIn);
            entranceCamSettingList.Add(Constant.ENTRANCE_2_CAM_OUT, comboBoxEntrance2CamOut);

            entranceCamSettingList.Add(Constant.ENTRANCE_1_CAM_QR, comboBoxEntrance1QRCode);
            entranceCamSettingList.Add(Constant.ENTRANCE_2_CAM_QR, comboBoxEntrance2QRCode);

            entranceStateSettingList.Add(Constant.ENTRANCE_1, comboBoxEntranceState1);
            entranceStateSettingList.Add(Constant.ENTRANCE_2, comboBoxEntranceState2);


            controlModeStatus = mode;
        }

        private void SystemManageForm_Load(object sender, EventArgs e)
        {
            comboBoxEntranceState1.SelectedIndexChanged -= comboBoxEntranceState1_SelectedIndexChanged;
            comboBoxEntranceState2.SelectedIndexChanged -= comboBoxEntranceState2_SelectedIndexChanged;
            listWebcamInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            
            foreach (var camSettingItem in entranceCamSettingList)
            {
                camSettingItem.Value.Items.Add("-");
                int index = 0;
                foreach (FilterInfo item in listWebcamInfo)
                {
                    camSettingItem.Value.Items.Add($"{item.Name} ({index})");
                    index++;
                }
            }

            foreach (var entranceSettingItem in entranceStateSettingList)
            {
                foreach (string state in barierState)
                {
                    entranceSettingItem.Value.Items.Add(state);
                }
            }

            foreach (var item in controlMode)
            {
                comboBoxControlMode.Items.Add(item);
            }

            List<Setting> settingsList = DB.GetAllSetting();
            if(settingsList != null)
            {
                foreach (var camSettingItem in entranceCamSettingList)
                {
                    Setting st = settingsList.FirstOrDefault(setting => setting.Name == camSettingItem.Key);
                    int index = 0;
                    if (st != null && st.Value != "")
                    {
                        index = int.Parse(st.Value) + 1;
                    }
                    if(index < camSettingItem.Value.Items.Count) {
                        camSettingItem.Value.SelectedIndex = index;
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
            comboBoxControlMode.SelectedItem = controlModeStatus;

            comboBoxEntranceState1.SelectedIndexChanged += comboBoxEntranceState1_SelectedIndexChanged;
            comboBoxEntranceState2.SelectedIndexChanged += comboBoxEntranceState2_SelectedIndexChanged;
        }

        private InternalEvent.UpdateControlModeDelegate GetUpdateControlMode()
        {
            return UpdateControlMode;
        }

        private void comboBoxEntranceState1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tempItemCbIn = 0;
            if(comboBoxEntrance1CamIn.SelectedItem != null)
            {
                tempItemCbIn = comboBoxEntrance1CamIn.SelectedIndex;
            }
            int tempItemCbOut = 0;
            if (comboBoxEntrance1CamOut.SelectedItem != null)
            {
                tempItemCbOut = comboBoxEntrance1CamOut.SelectedIndex;
            }
            comboBoxEntrance1CamIn.SelectedIndex = tempItemCbOut;
            comboBoxEntrance1CamOut.SelectedIndex = tempItemCbIn;
        }

        private void comboBoxEntranceState2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tempItemCbIn = 0;
            if (comboBoxEntrance2CamIn.SelectedItem != null)
            {
                tempItemCbIn = comboBoxEntrance2CamIn.SelectedIndex;
            }
            int tempItemCbOut = 0;
            if (comboBoxEntrance2CamOut.SelectedItem != null)
            {
                tempItemCbOut = comboBoxEntrance2CamOut.SelectedIndex;
            }
            comboBoxEntrance2CamIn.SelectedIndex = tempItemCbOut;
            comboBoxEntrance2CamOut.SelectedIndex = tempItemCbIn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var camSettingItem in entranceCamSettingList)
                {
                    if (camSettingItem.Value.SelectedIndex != -1)
                    {
                        int index = camSettingItem.Value.SelectedIndex;
                        if (index == -1 || index == 0)
                        {
                            DB.UpsertSetting(camSettingItem.Key, "");
                        }
                        else
                        {
                            DB.UpsertSetting(camSettingItem.Key, (index - 1).ToString());
                        }
                    }
                }

                foreach (var entranceSettingItem in entranceStateSettingList)
                {
                    string state = entranceSettingItem.Value.SelectedItem.ToString();
                    DB.UpsertSetting(entranceSettingItem.Key, state);
                }

                UpdateControlMode.Invoke(comboBoxControlMode.SelectedItem.ToString());
                ReloadMainForm.Invoke(this, null);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Config successfully {ex}");
            }
        }
    }
}
