using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToGoogle.Challenges.ArraysAndStrings
{
    public static class RotateImage
    {
        public static int[][] rotate(int[][] matrix)
        {
            //Time Complexity (O(N*N)) because there is 2 not nested for loops and it goes only through each cell in the matrix
            //Space O(1) - we do not use any additional data structures
            int n = matrix.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    //we are making transpose matrix
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
                //after transpose, it will be swap matrix on
                //1 2 3
                //4 5 6
                //7 8 9
                //became a =>
                //1 4 7
                //2 5 8
                //3 6 9
            }
            //now we just need swap the rows using 2 pointers
            //we are going to do so up to the middle (j<(N/2))
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n / 2); j++)
                {
                    //setting temp to the current element
                    int temp = matrix[i][j];
                    //now first pointer equal to the last pointer from the end but on the same distance from the end
                    matrix[i][j] = matrix[i][n - 1 - j];
                    matrix[i][n - 1 - j] = temp;
                }
            }

            return matrix;
        }
    }
}
