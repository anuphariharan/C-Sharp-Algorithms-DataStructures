using System;
using Newtonsoft.Json;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Strings
            //Console.WriteLine($"is it unique {Strings.HasUniqueChars("$uniqe")}");
            //Console.WriteLine($"After duplicate is removed {Strings.RemoveDuplicateCharacters("unique")}");
            //Console.WriteLine($"Are anagrams {Strings.AreAnagrams("Fri2ed", "Fired")}");
            //Console.WriteLine($"String replacement {Strings.ReplaceString("This is a test", ' ', "%20")}");
            //Console.WriteLine($"IsString “waterbottle” a rotation of “erbottlewat” {Strings.IsRotatedSubstring("erbottlewat", "waterbottle")}");
            //#endregion

            //#region Arrays
            //int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 0 }, { 7, 8 } };
            //Console.WriteLine($"Matrix Clockwise rotations of { JsonConvert.SerializeObject(array2Da) } is {JsonConvert.SerializeObject(Arrays.RotateMatrixClockwise(array2Da))}");
            //Console.WriteLine($"Matrix Counter Clockwise rotations of { JsonConvert.SerializeObject(array2Da) } is {JsonConvert.SerializeObject(Arrays.RotateMatrixCounterClockwise(array2Da))}");
            //Console.WriteLine($"MakeZero of { JsonConvert.SerializeObject(array2Da) } is {JsonConvert.SerializeObject(Arrays.MakeRowAndColumZero(array2Da))}");
            //#endregion


            //#region Recursion
            //int[] arr = { 2, 3, 4, 10, 40 };
            //int result = Recursion.BinarySearch(arr, 0, arr.Length - 1, 40); //For Binary search the assumption is that input Array is always sorted
            //Console.WriteLine(result != -1 ? "Element found at index " + result : "Element not present");
            //Console.WriteLine($"SimpleFibonacci {Recursion.SimpleFibonacci(6)}");
            //Console.WriteLine($"SimpleFibonacci {Recursion.FibonacciUsingMemoizedRecursion(6)}");
            //#endregion

            #region BinaryTrees
            int[] treeData = { 8, 6, 7, 12, 5, 1, 9 };
            BinaryTree.Node root = null;
            for (int i = 0; i < treeData.Length; i++)
                root = BinaryTree.Node.Insert(root, treeData[i]);
            Console.WriteLine($"PreOrder Traversal of Binary Tree is : ");
            BinaryTree.Node.PreOrder(root);
            Console.WriteLine();
            Console.WriteLine($"InOrder Traversal of Binary Tree is : ");
            BinaryTree.Node.InOrder(root);
            Console.WriteLine();
            Console.WriteLine($"PostOrder Traversal of Binary Tree is : ");
            BinaryTree.Node.PostOrder(root);
            #endregion

            Console.ReadLine();


        }
    }
}
