/*
Given a square matrix, calculate the absolute difference between the sums of its diagonals.

For example, the square matrix arr is shown below: 
1  2  3
4  5  6
9  8  9

The left-to-right diagonal 1 + 5 +9 = 15. The right to left diagonal 3 + 5 + 9 = 12 . Their absolute difference is 2

Function description:
diagonalDifference takes the following parameter:
    int arr[n][m]: an array of integers

Return:
    int: the absolute diagonal difference
*/

using System.Collections.Generic;
using System;

class Result
{

    public static int diagonalDifference(List<List<int>> arr)
    {
        var SumPrimary = 0;
        var sumSecondary = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            var row = arr[i];
            SumPrimary += row[i];
            sumSecondary += row[row.Count - (i + 1)];
        }

        return Math.Abs(SumPrimary - sumSecondary);
    }

}
