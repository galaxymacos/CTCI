using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI
{
    public static class StringLib
    {
        /// <summary>
        /// Determine if a string has all unique characters. 
        /// </summary>
        /// <param name="str">the input string</param>
        public static bool IsUnique(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// given two strings, decide if one is a permutation of the other
        /// </summary>
        /// <param name="str1">The first string that's given</param>
        /// <param name="str2">The seond string that's given</param>
        /// <returns></returns>
        public static bool IsPermutation(string str1, string str2)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < str1.Length; i++)
            {
                if (!dictionary.ContainsKey(str1[i]))
                {
                    dictionary.Add(str1[i], 1);
                }
                else
                {
                    dictionary[str1[i]] += 1;
                }
            }

            for (int j = 0; j < str2.Length; j++)
            {
                if (!dictionary.ContainsKey(str2[j]))
                {
                    return false;
                }

                dictionary[str2[j]] -= 1;
            }

            Dictionary<char, int>.KeyCollection keys = dictionary.Keys;
            foreach (var key in keys)
            {
                if (dictionary[key] != 0)
                {
                    return false;
                }
            }

            return true;

        }

        /// <summary>
        /// Replace all spaces in a string with '%20'
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplaceSpace(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    string stringBeforeSpace = str.Substring(0, i);
                    string stringAfterSpace = str.Substring(i+1, str.Length-i-1);
                    StringBuilder sb = new StringBuilder();
                    sb.Append(stringBeforeSpace);
                    sb.Append("%20");
                    sb.Append(stringAfterSpace);
                    str = sb.ToString();
                    i += 2;
                }
            }

            return str;
        }

        public static bool PalindromePermutation(string str1, string str2)
        {

            return IsPermutation(str1, str2) && IsPalindromePermutation(str1) && IsPalindromePermutation(str2);
        }

        private static bool IsPalindromePermutation(string str1)
        {
            for (int i = 0; i < str1.Length / 2 - 1; i++)
            {
                if (str1[i] != str1[str1.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool OneAway(string str1, string str2)
        {
            int discordScore = 0;
            if (str1.Length == str2.Length)
            {
                Console.WriteLine("two string has no differnece");

                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        discordScore++;
                    }
                }
                if (discordScore == 1)
                {
                    return true;
                }


                return false;
            }




            if (Math.Abs(str1.Length - str2.Length) == 1)
            {
                bool str1Longer = str1.Length > str2.Length;
                int str1Index = 0;
                int str2Index = 0;
                while (str1Index < str1.Length || str2Index < str2.Length)
                {
                    if (str1Index == str1.Length || str2Index == str2.Length) return true;
                    if (str1[str1Index] != str2[str2Index])
                    {
                        if (str1Longer)
                        {
                            str1 = str1.Substring(0, str1Index)+str1.Substring(str1Index+1, str1.Length -1 -str1Index);
                        }
                        else
                        {
                            str2 = str2.Substring(0, str2Index)+str2.Substring(str2Index+1, str2.Length -1-str2Index);
                        }

                        break;
                    }
                    str1Index++;
                    str2Index++;
                }

                if (String.Compare(str1, str2, StringComparison.Ordinal) == 0)
                {
                    return true;
                }

                return false;

            }

            Console.WriteLine("two strings have 2 difference");
            return false;
        }

        /// <summary>
        /// perform basic compression using the counts of repeated characters. For example, the string aabcccccaaa would become a2blc5a3
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StringCompression(string str)
        {
            if (str == "")
            {
                return "";
            }

            int scanningIndex = 0;
            char scanningLetter = str[scanningIndex];
            int repetition = 1;
            StringBuilder sb = new StringBuilder("");
            sb.Append(scanningLetter);
            while (scanningIndex+1 < str.Length)
            {
                scanningIndex++;
                if (scanningLetter == str[scanningIndex])
                {
                    repetition++;
                }
                else
                {
                    sb.Append(repetition);
                    repetition = 1;
                    scanningLetter = str[scanningIndex];
                    sb.Append(scanningLetter);
                }
            }
            sb.Append(repetition);
            return sb.ToString().Length >= str.Length ? str : sb.ToString();
        }

        public static int[,] RotateMatrix(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int[,] newMatrix = new int[n, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    newMatrix[j, m-i-1] = matrix[i, j];
                }
            }
            return newMatrix;
        }

        public static bool StringRotation(string str1, string str2)
        {
            return false;
        }
    }
}