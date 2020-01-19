using System.Collections.Generic;
using System;

namespace Algorithms.Sums
{
    public class PairSum
    {
        /// <summary>
        /// Finds all pairs with 'sum' within an 'array'
        /// </summary>
        public List<Tuple<int, int>> Find(int[] array, int sum)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            var ht = new Dictionary<int, int>();
            foreach (var num in array)
            {
                ht[num] = ht.GetValueOrDefault(num) + 1;
            }

            var result = new List<Tuple<int, int>>();

            foreach (var num in array)
            {
                ht[num] = ht.GetValueOrDefault(num) - 1;

                var secondNum = sum - num;
                if (ht.GetValueOrDefault(secondNum) > 0)
                {
                    ht[secondNum] = ht.GetValueOrDefault(secondNum) - 1;
                    result.Add(new Tuple<int, int>(num, secondNum));
                }
            }

            return result;
        }
    }
}