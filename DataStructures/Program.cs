﻿using System;
using Newtonsoft.Json;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strings
            Console.WriteLine($"is it unique {Strings.HasUniqueChars("$uniqe")}");
            Console.WriteLine($"After duplicate is removed {Strings.RemoveDuplicateCharacters("unique")}");
            Console.WriteLine($"Are anagrams {Strings.AreAnagrams("Fri2ed", "Fired")}");
            Console.WriteLine($"String replacement {Strings.ReplaceString("This is a test", ' ', "%20")}");
            Console.WriteLine($"IsString “waterbottle” a rotation of “erbottlewat” {Strings.IsRotatedSubstring("erbottlewat", "waterbottle")}");
            #endregion

            #region Arrays
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 0 }, { 7, 8 } };
            Console.WriteLine($"MAtrix Clockwise rotations of { JsonConvert.SerializeObject(array2Da) } is {JsonConvert.SerializeObject(Arrays.RotateMatrixClockwise(array2Da))}");
            Console.WriteLine($"MAtrix Counter Clockwise rotations of { JsonConvert.SerializeObject(array2Da) } is {JsonConvert.SerializeObject(Arrays.RotateMatrixCounterClockwise(array2Da))}");
            Console.WriteLine($"MakeZero of { JsonConvert.SerializeObject(array2Da) } is {JsonConvert.SerializeObject(Arrays.MakeRowAndColumZero(array2Da))}");
            #endregion

            Console.ReadLine();

        }
    }
}
