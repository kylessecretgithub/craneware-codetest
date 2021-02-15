using System.Text;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        public static string Reverse(string s)
        {
            if (s == null)
            {
                return "";
            }
            var sb = new StringBuilder();
            for(int i = s.Length - 1; i > -1; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();            
        }
    }
}
