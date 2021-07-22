using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Studio_3_class
{
    class CharacterCounting
    {
        public void FindChars(string sentence)
        {
            sentence = String.Concat(Array.FindAll(sentence.ToCharArray(), Char.IsLetterOrDigit));
            char[] charactersInString = sentence.ToLower().ToCharArray();
            var dictionary = new Dictionary<char, int>();
            

            foreach(char character in charactersInString)
            {
                int count = sentence.ToLower().Split(character).Length - 1;  

                if (!dictionary.ContainsKey(character))
                {
                    dictionary.Add(character, count);
                }
            }

            foreach(var pair in dictionary)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }

    }
}
