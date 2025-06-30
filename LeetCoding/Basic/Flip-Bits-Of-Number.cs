/*
You will be given a list of 32 bit unsigned integers. Flip all the bits (1 -> 0 and 0 -> 1) and return the result as an unsigned integer.

Example
n = 9<sub>10</sub>
9<sub>10</sub> = 1001<sub>2</sub>. We're working with 32 bits, so:
* 0000000000000000000000000001001<sub>2</sub> = 9<sub>10</sub>
* 1111111111111111111111111110110<sub>2</sub> = 4294967286<sub>10</sub>
Return 4294967286

Function Description
Complete the flippingBits function in the editor below.
flippingBits has the following parameter(s):
    int n: an integer

Returns
    int: the unsigned decimal integer result
*/

using System;
using System.Linq;

namespace LeetCoding.Basic;

internal class FlipBitsOfNumbers
{

    public static long flippingBits(long n)
    {
        string binaryValue = Convert.ToString(n, 2).PadLeft(32, '0');

        string flipped = string.Concat(binaryValue.Select(t => t == '1' ? '0' : '1').ToArray());
        Console.WriteLine(flipped);

        return Convert.ToInt64(flipped, 2);
    }

    public static void Main()
    {
        for (int qItr = 0; qItr < 3; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = FlipBitsOfNumbers.flippingBits(n);

            Console.WriteLine(result);
        }
    }
}
