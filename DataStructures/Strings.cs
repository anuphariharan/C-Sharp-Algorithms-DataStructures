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
                else
                {
                    ;
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


    }
}
