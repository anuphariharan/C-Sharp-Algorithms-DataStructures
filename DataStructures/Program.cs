using System;
using Newtonsoft.Json;

namespace DataStructures
{
    class Program
    {


        static void Main(string[] args)
        {
            #region Strings
            //Console.WriteLine($"is it unique {Strings.HasUniqueChars("$uniqe")}");
            //Console.WriteLine($"After duplicate is removed {Strings.RemoveDuplicateCharacters("unique")}");
            //Console.WriteLine($"Are anagrams {Strings.AreAnagrams("Fri2ed", "Fired")}");
            //Console.WriteLine($"String replacement {Strings.ReplaceString("THis is a test", ' ', "%20")}");
            #endregion

            #region Arrays
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            Console.WriteLine($"MAtrix rotations of { JsonConvert.SerializeObject(array2Da) } is {JsonConvert.SerializeObject(Arrays.RotateMatrixClockwise(array2Da))}");
            Console.WriteLine($"MAtrix rotations of { JsonConvert.SerializeObject(array2Da) } is {JsonConvert.SerializeObject(Arrays.RotateMatrixCounterClockwise(array2Da))}");
            
            #endregion

            Console.ReadLine();

        }
    }
}
