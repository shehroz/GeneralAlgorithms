using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericAlgorithms
{
    public class ReorderLogFilesClass
    {
        public static string[] ReorderLogFiles(string[] logs)
        {
            SortedList<string, string> letterLog = new SortedList<string, string>();
            var digitlogs = new List<string>();
            for (int i = 0; i < logs.Length; i++)
            {
                if (char.IsDigit(logs[i][logs[i].IndexOf(' ') + 1]))
                    digitlogs.Add(logs[i]);
                else
                    if (!letterLog.ContainsKey(logs[i].Substring(logs[i].IndexOf(' ') + 1)))
                    letterLog.Add(logs[i].Substring(logs[i].IndexOf(' ') + 1), logs[i]);
                else
                {
                    char firstLetter = Convert.ToChar(letterLog[logs[i].Substring(logs[i].IndexOf(' ') + 1)].Substring(0,1));
                    char secondLetter = Convert.ToChar(logs[i].Substring(0, 1));
                    if(secondLetter < firstLetter)
                    {
                        string firstsentense = letterLog[logs[i].Substring(logs[i].IndexOf(' ') + 1)];
                        letterLog[logs[i].Substring(logs[i].IndexOf(' ') + 1)] = logs[i];
                        letterLog.Add(logs[i].Substring(logs[i].IndexOf(' ') + 1) + i,firstsentense);
                    }
                    else
                    {
                        letterLog.Add(logs[i].Substring(logs[i].IndexOf(' ') + 1) + i, logs[i]);
                    }
                    
                    
                }
            }
            List<string> result = new List<string>();
            foreach (var item in letterLog)
                result.Add(item.Value);

            foreach (var item in digitlogs)
                result.Add(item);

            return result.ToArray();
        }

        public string[] ReorderLogFiles_working(string[] logs)
        {
            var letterLogs = new List<string>();
            var digitlogs = new List<string>();
            for (int i = 0; i < logs.Length; i++)
            {
                if (char.IsDigit(logs[i][logs[i].IndexOf(' ') + 1]))
                    digitlogs.Add(logs[i]);
                else
                    letterLogs.Add(logs[i]);
            }

            letterLogs.Sort((a, b) =>
            {
                int indexa = a.IndexOf(' ');
                int indexb = b.IndexOf(' ');
                string suba = a.Substring(indexa + 1);
                string subb = b.Substring(indexb + 1);

                int compare = suba.CompareTo(subb);
                if (compare != 0)
                    return compare;

                return a.Substring(0, indexa).CompareTo(b.Substring(0, indexb));
            });

            return letterLogs.Concat(digitlogs).ToArray();
        }
    }
}

