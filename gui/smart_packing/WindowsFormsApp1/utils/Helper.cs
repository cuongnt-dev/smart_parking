using System;
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

        public static double CalculateSimilarity(string str1, string str2)
        {
            int distance = CalculateDistance(str1, str2);
            int maxLength = Math.Max(str1.Length, str2.Length);

            // Calculate the similarity as a percentage
            double similarity = (1.0 - (double)distance / maxLength) * 100.0;

            return similarity;
        }

        public static int CalculateDistance(string str1, string str2)
        {
            int lenStr1 = str1.Length + 1;
            int lenStr2 = str2.Length + 1;

            int[,] matrix = new int[lenStr1, lenStr2];

            // Initialization
            for (int i = 0; i < lenStr1; i++)
                matrix[i, 0] = i;

            for (int j = 0; j < lenStr2; j++)
                matrix[0, j] = j;

            // Fill in the matrix
            for (int i = 1; i < lenStr1; i++)
            {
                for (int j = 1; j < lenStr2; j++)
                {
                    int cost = (str1[i - 1] == str2[j - 1]) ? 0 : 1;

                    matrix[i, j] = Math.Min(
                        matrix[i - 1, j] + 1,      // Deletion
                        Math.Min(
                            matrix[i, j - 1] + 1,  // Insertion
                            matrix[i - 1, j - 1] + cost  // Substitution
                        )
                    );
                }
            }

            // Return the Levenshtein distance
            return matrix[lenStr1 - 1, lenStr2 - 1];
        }
    }
}
