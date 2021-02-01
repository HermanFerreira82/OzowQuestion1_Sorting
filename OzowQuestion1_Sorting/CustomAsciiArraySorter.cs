using System;
using System.Text;
using System.Text.RegularExpressions;

namespace OzowQuestion1_Sorting
{
    /// <summary>
    /// This is my Custom Sorter based on the ASCII table.
    /// Result is sorted string @ O(n) = n
    /// </summary>
    public class CustomAsciiArraySorter : ICustomSorter
    {
        private readonly int[] _charCountArray ;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CustomAsciiArraySorter()
        {
            _charCountArray = new int[26];
        }

        /// <summary>
        /// Sort any string (no special characters)
        /// </summary>
        /// <param name="sentence">A sentence string</param>
        /// <returns>Sorted String</returns>
        public string Sort(string sentence)
        {
            // Business rule 1 - map uppercase to lowercase
            var result = sentence.ToLowerInvariant();

            //Business rule 2 - remove special characters
            result = Regex.Replace(result, @"[^0-9a-z]", string.Empty, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            
            byte[] asciiBytes = Encoding.ASCII.GetBytes(result);

            // Character Count
            foreach (var character in asciiBytes)
            {
                _charCountArray[character - 97]++;
            }

            result = String.Empty;
            for(int i = 0; i < 26; i++)
            {
                for (int j = 0; j < _charCountArray[i]; j++)
                {
                    result += (char) (i + 97);
                }
            }

            return result;
        }
    }
}
