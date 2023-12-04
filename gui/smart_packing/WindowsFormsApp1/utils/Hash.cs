using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1.utils
{
    internal class Hash
    {
        static public string HashString(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return String.Empty;
            }

            // Uses SHA256 to create the hash
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                // Convert the string to a byte array first, to be processed
                byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hashBytes = sha.ComputeHash(textBytes);

                // Convert back to a string, removing the '-' that BitConverter adds
                string hash = BitConverter
                    .ToString(hashBytes)
                    .Replace("-", String.Empty);

                return hash;
            }
        }

        static public (int, int) ExtractRegister(string input)
        {
            // Define the regular expression pattern
            string pattern = @"(\d+)_(\d+)";

            // Use Regex.Match to find the matches
            Match match = Regex.Match(input, pattern);

            // Check if the pattern is matched
            if (match.Success)
            {
                // Extract the first and second numbers from the matched groups
                int firstNumber = int.Parse(match.Groups[1].Value);
                int secondNumber = int.Parse(match.Groups[2].Value);

                // Return the numbers as a tuple
                return (firstNumber, secondNumber);
            }
            else
            {
                // Return default values or handle the case where the pattern is not matched
                return (0, 0);
            }
        }
    }
}
