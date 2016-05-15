using System.Text;

namespace Jarvis.Utils
{
    public static class StringMerger
    {
        public static string MergeArray(params string[] Args)
        {
            StringBuilder b = new StringBuilder();
            foreach (string s in Args)
            {
                b.Append(s);
            }
            return b.ToString();
        }
    }
}
