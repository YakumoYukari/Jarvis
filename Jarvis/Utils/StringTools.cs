using System;
using System.Linq;
using System.Text;

namespace Jarvis.Utils
{
    public static class StringTools
    {
        public static int CountCharacterInstances(string Source, char CharToFind, int StartIndex = 0)
        {
            int Found = 0;
            for (int i = StartIndex; i < Source.Length; i++)
                if (Source[i] == CharToFind) Found++;
            return Found;
        }

        public static string MergeArray(params string[] Args)
        {
            StringBuilder b = new StringBuilder();
            foreach (string s in Args)
            {
                b.Append(s);
            }
            return b.ToString();
        }

        public static bool MatchesWithWildcard(string First, string Second, string Wildcard = "*", string Delimiter = " ")
        {
            var SplitFirst = First.Split(new[] { Delimiter }, StringSplitOptions.None);
            var SplitSecond = Second.Split(new[] { Delimiter }, StringSplitOptions.None);

            //First must be shorter length than second
            if (SplitFirst.Length > SplitSecond.Length)
            {
                var Swap = SplitFirst;
                SplitFirst = SplitSecond;
                SplitSecond = Swap;
            }

            //Allow wildcards on the end to match any trailing amount
            if (SplitFirst.Length < SplitSecond.Length && SplitFirst[SplitFirst.Length - 1] != Wildcard) return false;

            return !SplitFirst.Where((t, i) => t != SplitSecond[i] && t != Wildcard && SplitSecond[i] != Wildcard).Any();
        }
    }
}
