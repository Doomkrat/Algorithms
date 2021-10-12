using System.Linq;
using System.Text;

namespace RoadToGoogle.Challenges
{
    public static class LicenseKeyFormatting
    {
        public static string LicenseKeyFormattingMethod(string s, int k)
        {
            StringBuilder ans = new StringBuilder();
            int cnt = 0, n = s.Length;
            char c;
            for (int i = n - 1; i >= 0; i--)
            {
                c = s[i];
                if (c != '-')
                {
                    if (cnt == k)
                    {
                        ans.Append('-');
                        cnt = 0;
                    }
                    cnt++;
                    ans.Append(c);
                }
            }

            var b = ans.ToString();
            return new string(b.Reverse().ToArray()).ToUpper();
        }
    }
}
