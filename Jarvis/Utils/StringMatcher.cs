using System;
using System.Linq;

namespace Jarvis.Utils
{
    public static class StringMatcher
    {
        public static bool MatchesWithWildcard(string First, string Second, string Wildcard = "*", string Delimiter = " ")
        {
            var splitFirst = First.Split(new[] { Delimiter }, StringSplitOptions.None);
            var splitSecond = Second.Split(new[] { Delimiter }, StringSplitOptions.None);

            if (splitFirst.Length != splitSecond.Length) return false;

            return !splitFirst.Where((t, i) => t != splitSecond[i] && t != Wildcard && splitSecond[i] != Wildcard).Any();
        }
    }
}
