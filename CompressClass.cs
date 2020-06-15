using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public static class CompressClass
    {
        
        public static int Compress(char[] chars)
        {
            int index = 0, resindex = 0;
            
            while (index < chars.Length)
            {
                int count = 0;
                char curr = chars[index];
                while(index< chars.Length && curr == chars[index])
                {
                    count++;
                    index++;
                }
                chars[resindex] = curr;
                resindex++;

                if (count > 1)
                {
                    foreach (var c in count.ToString().ToCharArray())
                    {
                        chars[resindex] = c;
                        resindex++;
                    }
                }
            }
            return resindex;
        }
        
    }
}
