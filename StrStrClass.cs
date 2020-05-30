using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class StrStrClass
    {
        public  static int StrStr(string haystack, string needle)
        {
            if (haystack == "" && needle == "")
                return 0;
            else if (haystack == "")
                return -1;
            else if (needle == "")
                return 0;
            int index = 0;
            bool IsFound = false;
            int lastIndex = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[index])
                {
                    index++;
                    IsFound = true;
                    lastIndex = i;
                    if (index >= needle.Length)
                        break;
                }
                else
                {
                    i -= index;
                    index = 0;
                    IsFound = false;
                }
            }
            if(IsFound && index==needle.Length)
            {
                return lastIndex - (needle.Length-1) ;
            }
            else
            {
                return -1;
            }
        }

        
    }
}
