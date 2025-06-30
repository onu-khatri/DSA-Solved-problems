/*
Comparison Sorting
Quicksort usually has a running time of n x log(n), but is there an algorithm that can sort even faster? In general, this is not possible. Most sorting algorithms are comparison sorts, i.e. they sort a list just by comparing the elements to one another. A comparison sort algorithm cannot beat n x log(n) (worst-case) running time, since
n x log(n) represents the minimum number of comparisons needed to know where to place each element. For more details, you can see these notes (PDF).

Alternative Sorting
Another sorting method, the counting sort, does not require comparison. Instead, you create an integer array whose index range covers the entire range of values in your array to sort. Each time a value occurs in the original array, you increment the counter at that index. At the end, run through your counting array, printing the value of each non-zero valued index that number of times.

Example
arr = [1, 1, 3, 2, 1]
All of the values are in the range , so create an array of zeros, result = [0, 0, 0, 0]. The results of each iteration follow:

The frequency array is [0, 3, . These values can be used to create the sorted array as well: 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCoding.Basic;

internal class Result
{
    public static List<int> countingSort(List<int> arr)
    {
        int[] frequency = new int[100];
        var rightIndex = arr.Count - 1;

        for (int i = 0; i < arr.Count; i++)
        {

            if (i > rightIndex)
                break;

            if (i < rightIndex)
            {
                frequency[arr[rightIndex]] = ++frequency[arr[rightIndex]];
                rightIndex--;
            }

            frequency[arr[i]] = ++frequency[arr[i]];
        }

        return frequency.ToList();

    }

    public static void Main()
    {
        var numberArray = "1 2 3 4 5 6 7 8 9 10 1 2 3 4 5 6 7 8 9 9".Split(' ');
        var flippingBit = countingSort(numberArray.Select(t => System.Convert.ToInt32(t)).ToList());
        Console.WriteLine(String.Join(", ", flippingBit));
    }
}
