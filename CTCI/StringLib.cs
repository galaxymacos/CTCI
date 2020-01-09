﻿using System;
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
    }
}