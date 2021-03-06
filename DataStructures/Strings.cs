using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{

    public static class Strings
    {
        public static bool HasUniqueChars(string str)
        {
            bool[] char_set = new bool[256];
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (char_set[val]) return false;
                char_set[val] = true;
            }
            return true;
        }

        public static string RemoveDuplicateCharacters(string str)
        {
            
            bool[] char_set = new bool[256];
            var sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (!char_set[val])
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }

        public static bool AreAnagrams(string string1, string string2)
        {
            bool areAnagrams = true;
            if (string1.Length != string2.Length) return false;

            bool[] char_set = new bool[256];
            for (int i = 0; i < string1.Length; i++)
            {
                int val = string1[i];
                char_set[val] = true;
            }
            for (int i = 0; i < string2.Length; i++)
            {
                int val = string1[i];
                if (!char_set[val])
                {
                    areAnagrams = false;
                    break;
                }
            }
            return areAnagrams;
        }

        public static string ReplaceString(string sentence, char character, string replacementString)
        {

            var sb = new StringBuilder();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == character)
                {
                    sb.Append(replacementString);
                }
                else
                {
                    sb.Append(sentence[i]);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Assume you have a method isSubstring which checks if one word is a substring of
        //  another.Given two strings, string1 and string2, write code to check if string2 is a rotation of string1 (i.e., “waterbottle” is a rotation of “erbottlewat”).
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        /// <returns></returns>
        public static bool IsRotatedSubstring(string string1, string string2)
        {
            return (string1 + string1).Contains(string2);
        }


    }
}
