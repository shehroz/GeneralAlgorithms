using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    class Helper
    {
        public static string DictionaryToString(Dictionary<string, string> dictionary)
        {
            string dictionaryString = "{";
            foreach (KeyValuePair<string, string> keyValues in dictionary)
            {
                dictionaryString += keyValues.Key;
            }
            return dictionaryString.TrimEnd(',', ' ') + "}";
        }
        public static string DictionaryToString(Dictionary<char, int> dictionary)
        {
            string dictionaryString = "{";
            foreach (KeyValuePair<char, int> keyValues in dictionary)
            {
                dictionaryString += keyValues.Key;
            }
            return dictionaryString.TrimEnd(',', ' ') + "}";
        }
        public static string RemoveSpaceFromSubstring(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    result += str[i];
            }
            return result;
        }
        public static int ToInt(char c)
        {
            return (int)(c - '0');
        }
        public static int ToInt(string c)
        {
            //char ch= Convert.ToChar(c);
            //return (int)(ch - '0');
            return Convert.ToInt32(c);
        }
        static T CreateJaggedArray<T>(params int[] lengths)
        {
            return (T)InitializeJaggedArray(typeof(T).GetElementType(), 0, lengths);
        }

        static object InitializeJaggedArray(Type type, int index, int[] lengths)
        {
            Array array = Array.CreateInstance(type, lengths[index]);
            Type elementType = type.GetElementType();

            if (elementType != null)
            {
                for (int i = 0; i < lengths[index]; i++)
                {
                    array.SetValue(
                        InitializeJaggedArray(elementType, index + 1, lengths), i);
                }
            }

            return array;
        }
    }
}
