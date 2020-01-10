
using System;

namespace CTCI
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            
            // Console.WriteLine(StringLib.IsUnique(""));
            // Console.WriteLine(StringLib.IsUnique(""));
            //
            // Console.WriteLine(StringLib.IsPermutation("abcdef","acedbf"));
            //
            // Console.WriteLine(StringLib.ReplaceSpace("a b "));
            //
            // Console.WriteLine(StringLib.PalindromePermutation("taco cat", "atco cta"));

            // Console.WriteLine(StringLib.OneAway("balee","balea"));

            // Console.WriteLine(StringLib.StringCompression("aaaaaabc"));

            int[,] testMatrix = new int[3, 5] {{1, 2, 3, 4, 5}, {6, 7, 8, 9, 10}, {11, 12, 13, 14, 15}};
            
            for (int i = 0; i < testMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < testMatrix.GetLength(1); j++)
                {
                    Console.Write(testMatrix[i,j]);
                }

                Console.WriteLine();
            }
            
            int[,] newMatrix = StringLib.RotateMatrix(testMatrix);
            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    Console.Write(newMatrix[i,j]+" ");
                }

                Console.WriteLine();
            }
        }
    }
}