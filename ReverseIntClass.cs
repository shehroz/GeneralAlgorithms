using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class ReverseIntClass
    {
        public int Reverse(int x)
        {
            long reversed = 0;
            while (x != 0)
            {
                reversed = reversed * 10 + x % 10;
                x = x / 10;
                if(reversed > int.MaxValue || reversed < int.MinValue)
                {
                    return 0;
                }
            }

            return (int)reversed;
        }
        public int Reverse_usingstring(int x)
        {
            bool IsNegativeNumber = false;
            int posNum = 0;
            if (x > 0)
                posNum = x;
            else
            {
                posNum = x * (-1);
                IsNegativeNumber = true;
            }
            char[] charArray = posNum.ToString().ToCharArray();
            int len = charArray.Length - 1;
            for (int i = 0; i < charArray.Length / 2; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[len];
                charArray[len] = temp;
                len--;
            }

            string res = new string(charArray);
            int outputInt;
            if (!IsNegativeNumber)
            {
                int.TryParse(res, out outputInt);
            }
            else
            {
                int.TryParse(res, out outputInt);
                outputInt = outputInt * (-1);


            }
            return outputInt;
        }
    }
}
