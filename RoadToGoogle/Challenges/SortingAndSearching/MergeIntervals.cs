using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToGoogle.Challenges.SortingAndSearching
{
    public static class MergeIntervals
    {
        //Time: O(nlogn)
        //Space O(n)
        public static int[][] Merge(int[][] intervals)
        {
            //quick sorting of all arrays in the array -> we need cast to list since list has sorting function
            var listIntervals = intervals.ToList();
            listIntervals.Sort((x,y)=> x[0].CompareTo(y[0]));

            //result we will put to the linked list
            LinkedList<int[]> merged = new LinkedList<int[]>();

            foreach (int[] interval in listIntervals)
            {
                //if list is empty or second boundary less than first boundary of the next array we just adding the array to the list
                if (merged.Count == 0 || merged.Last()[1] < interval[0])
                {
                    merged.AddLast(interval);
                }
                else
                {
                    //replacing right boundary element of the last linked list array with bigger value among current array and list of intervals
                    merged.Last()[1] = Math.Max(merged.Last()[1], interval[1]);
                }
            }

            return merged.ToArray();
        }
    }
}
