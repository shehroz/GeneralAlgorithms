using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class StrStrClass
    {
        public  static int StrStr(string haystack, string needle)
        {
            if ((haystack == "" && needle == "") || needle == "")
                return 0;
            else if (haystack == "")
                return -1;

            int index = 0, lastindex = -1;
            for (int i = 0; i < haystack.Length && index < needle.Length; i++)
            {
                if (haystack[i] == needle[index])
                {
                    index++;
                    lastindex = i;
                }
                else
                {
                    i = i - index;
                    index = 0;
                }
            }
            if (lastindex != -1 && index == needle.Length)
                return lastindex - index + 1;
            else
                return -1;
        }

        
    }
}
