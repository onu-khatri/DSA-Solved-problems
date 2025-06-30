using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteByteCoding.TwoPointers.NumberPairs
{
    internal class PairSumSorted
    {
        public static List<int[]> FindPairs(int[] arr, int target)
        {
            return FindPairsSpan(new Span<int>(arr), target);
        }


        public static List<int[]> FindPairsSpan(Span<int> arr, int target)
        {
            int leftIndex = 0, rightIndex = arr.Length - 1;
            List<int[]> result = [];

            do
            {
                var leftValue = arr[leftIndex];
                var rightValue = arr[rightIndex];
                var valueSum = leftValue + rightValue;

                if (leftIndex > 0 && arr[leftIndex] == arr[leftIndex - 1])
                {
                    leftIndex++;
                    continue;
                }

                if (valueSum == target)
                {
                    result.Add([leftValue, rightValue]);
                }

                if (valueSum <= target)
                {
                    leftIndex++;
                }

                if (valueSum > target)
                {
                    rightIndex--;
                }
            } while (leftIndex < rightIndex);

            return result;
        }
    }
}
