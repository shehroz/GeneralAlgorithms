using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GenericAlgorithms
{
    public class MyAtoiClass
    {
        public static int MyAtoi(string str)
        {
            str = str.Trim();
            if (str.Length == 0)
                return 0;
            else if (str.Contains("+") && str.Contains("-"))
                return 0;
            int num = 0,lastDiff=0;
            int multiplier = 1;
            Regex reg = new Regex("[0-9-+]");
           
            bool IsNegativeNumber = false;
            char firstCharacter = str[0];
            int index = 0;
            if (firstCharacter == '-' )
            {
                index = 1;
                IsNegativeNumber = true;
            }
            else if(firstCharacter == '+')
            {
                index = 1;
            }
            bool isMatched=reg.IsMatch(firstCharacter.ToString());
            if(isMatched)
            {
                for (int i = str.Length - 1; i >= index; i--)
                {
                    if (reg.IsMatch(str[i].ToString()))
                    {
                        int temp = (int)(str[i] - '0');
                        temp *= multiplier;
                        lastDiff = int.MaxValue - num;
                        if (lastDiff < temp || num > int.MaxValue / 10 || (num == int.MaxValue / 10 && (int)(str[i] - 48) > int.MaxValue % 10))
                        {
                           
                            if (IsNegativeNumber)
                            {
                                lastDiff = num - (int.MinValue);
                                num -= (lastDiff);
                                if (i == index)
                                {
                                    num *= (-1);
                                    if (num > int.MinValue)
                                        return num;
                                }
                                return int.MinValue;
                            }
                            else
                            {
                                num += lastDiff;
                                if (i == index)
                                {
                                    if (num < int.MaxValue)
                                        return num;
                                }
                                return int.MaxValue;
                            }
                        }
                        num += (temp);
                        multiplier *= 10;
                    }
                    else
                    {
                        num = 0;
                        multiplier = 1;
                    }
                }

                
                if (IsNegativeNumber)
                    return num *= (-1);
                return num;
            }
            return 0;
        }
        public static int atoi(string str)
        {            
            str = str.Trim();
            if (string.IsNullOrEmpty(str))
                return 0;
            double result = 0;
            int startingIndex = 0;
            bool isNegativeNumber = false;
            Regex reg = new Regex("[0-9]");

            if (str[0] == '-' || str[0] == '+')
                startingIndex++;
            if (str[0] == '-')
                isNegativeNumber = true;

            for (int i = startingIndex; i < str.Length; i++)
            {
                if(reg.IsMatch(str[i].ToString()))
                {
                    int temp = str[i] - '0';
                    result = result * 10 + temp;
                }
                else
                     break; 
            }

            if (isNegativeNumber)
                result *= (-1);

            if (result > int.MaxValue)
                return int.MaxValue;
            if (result < int.MinValue)
                return int.MinValue;

            return (int)result;
        }
    }
}
