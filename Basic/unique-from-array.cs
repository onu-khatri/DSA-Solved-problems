/*
Given an array of integers, where all elements but one occur twice, find the unique element.

Example
The unique element is 4

Function Description
Complete the lonelyinteger function in the editor below.
lonelyinteger has the following parameter(s):
    int a[n]: an array of integers

Returns
    int: the element that occurs only once
*/

using System.Collections.Generic;
using System.Linq;
using System;

class Result
{
    public static int lonelyinteger(List<int> a)
    {
        Dictionary<int, int> valueWithCount = new Dictionary<int, int>();
        for (int i = 0; i < a.Count; i++)
        {
            var value = 0;
            var key = a[i];
            if (valueWithCount.ContainsKey(key))
            {
                value = valueWithCount[key];
            }

            value++;

            valueWithCount[key] = value;
        }

        var result = valueWithCount.FirstOrDefault(t => t.Value == 1);
        return result.Key;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> a = new List<int> { 1, 2, 3, 4, 3, 2, 1 };

        int result = Result.lonelyinteger(a);

        Console.WriteLine($"The unique element is {result}");
    }
}
