
using System;

namespace CTCI
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine(StringLib.IsUnique(""));
            Console.WriteLine(StringLib.IsUnique(""));
            
            Console.WriteLine(StringLib.IsPermutation("abcdef","acedbf"));

            Console.WriteLine(StringLib.ReplaceSpace("a b "));
            
        }
    }
}