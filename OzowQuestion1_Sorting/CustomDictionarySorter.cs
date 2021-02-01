using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OzowQuestion1_Sorting
{
    /// <summary>
    /// This is my Custom Sorter based on the builtin dictionary component.
    /// The builtin dictionary is based on a Hash function which will
    /// allow for O(n) = 1 for inserting and reading
    /// Result is sorted string @ O(n) = n
    /// </summary>
    public class CustomDictionarySorter : ICustomSorter
    {
        private readonly Dictionary<char, int> _charCountDictionary;

        /// <summary>
        /// Default constructor 
        /// </summary>
        public CustomDictionarySorter()
        {
            _charCountDictionary = new Dictionary<char, int>();
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
            
            // Character Count
            foreach (var character in result)
            {
                if (_charCountDictionary.TryGetValue(character, out var count))
                {
                    _charCountDictionary[character] = count + 1;
                }
                else
                {
                    _charCountDictionary[character] = 1;
                }
                
            }

            // Return sorted
            result = string.Empty;
            foreach (var character in "abcdefghijklmnopqrstuvwxyz")
            {
                if (_charCountDictionary.TryGetValue(character, out var _))
                {
                    for (int i = 0; i < _charCountDictionary[character]; i++)
                    {
                        result += character;
                    }
                }
            }

            return result;
        }
    }
}
