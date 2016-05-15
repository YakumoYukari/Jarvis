using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarvisRobot.Utils
{
    public static class StringMerger
    {
        public static string MergeArray(params string[] args)
        {
            StringBuilder b = new StringBuilder();
            foreach (string s in args)
            {
                b.Append(s);
            }
            return b.ToString();
        }
    }
}
