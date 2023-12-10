﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.utils
{
    internal class Helper
    {
        public static bool HasValue(string val)
        {
            if(val != null && val != "")
            {
                return true;
            }
            return false;
        }

        public static string GetCurrentDay()
        {
            DateTime currentDay = DateTime.Today;
            return currentDay.ToString("MMddyyyy");
        }

        public static void PlaySound(string state)
        {
            try
            {
                string path = "";
                if(state == Constant.CHECKIN_STATE)
                {
                    path = $"{Constant.SOUND_PATH}\\checkin.wav";
                } else if (state == Constant.CHECKOUT_STATE)
                {
                    path = $"{Constant.SOUND_PATH}\\checkout.wav";
                } else if (state == Constant.RECOGNIZE_QR_STATE) {
                    path = $"{Constant.SOUND_PATH}\\recognize_qr_code.wav";
                }
                    // Create a SoundPlayer instance with the path to the audio file
                    using (SoundPlayer player = new SoundPlayer(path))
                {
                    // Play the audio
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
