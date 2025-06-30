using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteByteCoding.TwoPointers.NumberPairs
{
    internal class PairTripletSum
    {
        public static List<int[]> FindPairs(int[] arr, int target)
        {
            var sortedArray = arr.Order();
            List<int[]> result = [];

            for (int i = 0; i < arr.Length; i++)
            {
                var subArrayTarget = target - arr[i];

                if (subArrayTarget <= 0) continue;

                if (i > 0 && arr[i] == arr[i - 1]) continue;

                var span = new Span<int>(arr, i, arr.Length - i);

                var subArrayResult = PairSumSorted.FindPairsSpan(span, subArrayTarget);

                if (subArrayResult.Count > 0)
                {
                    result.AddRange(subArrayResult.Select(t => new int[] { arr[i], t[0], t[1] }));
                }
            }

            return result;
        }
    }
}
