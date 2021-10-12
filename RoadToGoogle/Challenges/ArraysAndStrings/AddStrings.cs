using System;
using System.Linq;
using System.Text;

namespace RoadToGoogle.Challenges.ArraysAndStrings
{
    public static class AddStrings
    {
        //Time complexity: O(max(N1,N2))
        //Space complexity: O(max(N1,N2))
        public static string addStrings(String num1, String num2)
        {
            StringBuilder res = new StringBuilder();

            int carry = 0;

            //set a pointer in the end of each string
            int p1 = num1.Length - 1;
            int p2 = num2.Length - 1;

            while(p1>=0 || p2 >= 0)
            {
                // - '0' converts char to int and we can do math addition in this case
                int x1 = p1 >= 0 ? num1[p1] - '0' : 0;
                int x2 = p2 >= 0 ? num2[p2] - '0' : 0;

                //compute the current value
                int value = (x1 + x2 + carry) % 10;
                carry = (x1 + x2 + carry) / 10;
                //append it to the result
                res.Append(value);
                p1--;
                p2--;
            }
            if (carry != 0)
                res.Append(carry);

            return new string(res.ToString().Reverse().ToArray());
        }

    }
}
