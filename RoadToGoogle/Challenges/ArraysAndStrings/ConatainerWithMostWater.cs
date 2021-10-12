using System;

namespace RoadToGoogle.Challenges.ArraysAndStrings
{
    public static class ConatainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            //Time:O(N) because while loop traverse throug the N elements
            //Space:O(1)

            //intitialize max to zero
            int max = 0;
            //intitalize left and right to extreme ends of array
            int left = 0;
            int right = height.Length - 1;
            //while lefy<right, loop
            while (left < right)
            {
                //calculate current area and update max area
                int currentArea = Math.Min(height[left], height[right]) * (right - left);
                max = Math.Max(max, currentArea);
                //take descicion which poinet to move
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return max;
        }
    }
}
