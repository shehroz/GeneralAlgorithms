using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class CompareVersionClass
    {
        public static int CompareVersion(string version1, string version2)
        {
            string[] ver1 = version1.Split('.');
            string[] ver2 = version2.Split('.');
            int n = ver1.Length > ver2.Length ? ver1.Length : ver2.Length;

            for (int i = 0; i < n; i++)
            {
                if (i >= ver2.Length)
                {
                    if (Convert.ToInt32(ver1[i]) > 0)
                        return 1;
                    continue;
                }
                if (i >= ver1.Length)
                {
                    if (Convert.ToInt32(ver2[i]) > 0)
                        return -1;
                    continue;
                }
                if (Convert.ToInt32(ver1[i].ToString()) > Convert.ToInt32(ver2[i].ToString()))
                    return 1;
                else if (Convert.ToInt32(ver2[i]) > Convert.ToInt32(ver1[i].ToString()))
                    return -1;


            }
            return 0;
        }
        
    }
}
