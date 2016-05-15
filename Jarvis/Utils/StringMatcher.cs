using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarvisRobot.Utils
{
    public static class StringMatcher
    {
        public static bool MatchesWithWildcard(string First, string Second, string Wildcard = "*", string Delimiter = " ")
        {
            string[] SplitFirst = First.Split(new string[] { Delimiter }, StringSplitOptions.None);
            string[] SplitSecond = Second.Split(new string[] { Delimiter }, StringSplitOptions.None);

            if (SplitFirst.Length != SplitSecond.Length) return false;

            for (int i = 0; i < SplitFirst.Length; i++)
                if (SplitFirst[i] != SplitSecond[i] && (SplitFirst[i] != Wildcard && SplitSecond[i] != Wildcard))
                    return false;

            return true;
        }
    }
}
