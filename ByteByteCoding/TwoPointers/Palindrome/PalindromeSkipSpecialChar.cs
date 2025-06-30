using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteByteCoding.TwoPointers.Palindrome
{
    internal class PalindromeSkipSpecialChar
    {
        public static bool IsPalindrome(string text, char[] specialCharacters)
        {
            var textData = text.AsSpan();

            var leftIndex = 0;
            var rightIndex = textData.Length - 1;
            var isPalindrome = true;

            do
            {
                var leftChar = textData[leftIndex];
                var rightChar = textData[rightIndex];

                while (specialCharacters.Any(t => t == leftChar)) { leftIndex++; leftChar = textData[leftIndex]; };
                while (specialCharacters.Any(t => t == rightChar)) { rightIndex--; rightChar = textData[rightIndex]; };

                if (leftChar != rightChar)
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
