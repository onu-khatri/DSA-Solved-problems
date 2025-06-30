using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteByteCoding.TwoPointers.Palindrome
{
    internal class SimplePalindrome
    {
        public static bool IsPalindrome(string text)
        {
            var textData = text.AsSpan();

            var leftIndex = 0;
            var rightIndex = textData.Length - 1;
            var isPalindrome = true;

            do
            {
                if (textData[leftIndex] != textData[rightIndex])
                {
                    isPalindrome = false;
                    break;
                }

                leftIndex++;
                rightIndex--;

            } while (leftIndex > rightIndex);

            return isPalindrome;
        }
    }
}
