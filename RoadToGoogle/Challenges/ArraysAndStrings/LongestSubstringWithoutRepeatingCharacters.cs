using System;

namespace RoadToGoogle.Challenges.ArraysAndStrings
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        //time complexity is O(2n) same as O(n) - in worst case we need extend and contract the window n times for example for "bbbbbb" string
        //space complexity O(m) where m size of the table/array
        public static int LengthOfLongestSubstring(string s)
        {
            //creating direct access table where each letter, number, symbol is mapped to some index
            int[] chars = new int[128];

            //indexes for sliding window
            //left to contruct the window
            int left = 0;
            //right to extend the window
            int right = 0;

            int res = 0;
            
            //we are going to extend the window to the right untill right boundary will not reach end of
            while (right < s.Length)
            {
                //grabing current character
                char r = s[right];
                //adding this character to the array
                chars[r]++;

                //if character on the right boundarry appear more than once, we need to keep contructing the window
                while (chars[r] > 1)
                {
                    //grab left character
                    char l = s[left];
                    //and reduce it's occurence in the array
                    chars[l]--;
                    //and move forward left pointer
                    left++;
                }
                //need update max window length
                res = Math.Max(res, right - left + 1);

                right++;
            }
            return res;
        }
    }
}
