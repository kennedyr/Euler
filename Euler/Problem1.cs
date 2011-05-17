using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    static class Problem1
    {
        /// <summary>
        /// A quick and dirty algorithm.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>sum</returns>
        public static int SumTheMultiplesOf3And5(int limit)
        {
            int sum = 0;
            for (int i = 3; i < limit; i++)
            {
                if (i % 3==0 || i % 5==0)
                    sum += i;
            }
            return sum;
        }
        /// <summary>
        /// A more efficient algorithm that removes unnecessary conditionals
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>sum</returns>
        public static int SumTheMultiplesOf3And5_Optimized(int limit)
        {
            return SumMultiplesOf(limit, 3) + SumMultiplesOf(limit, 5) - SumMultiplesOf(limit, 15);
        }

        /// <summary>
        /// An even more efficient algorithm that calculates the sums mathematically
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>sum</returns>
        public static int SumTheMultiplesOf3And5_Mathematically(int limit)
        {
            return SumMultiplesOf_Mathematically(limit, 3) + SumMultiplesOf_Mathematically(limit, 5) - SumMultiplesOf_Mathematically(limit, 15);
        }

        

        #region Helper Functions
        
        /// <summary>
        /// Sums multiples of 'multiple' up to 'limit' iteratively
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="multiple"></param>
        /// <returns>sum</returns>
        public static int SumMultiplesOf(int limit, int multiple)
        {
            int sum = 0;
            for (int i = multiple; i < limit; i += multiple)
            {
                sum += i;
            }
            return sum;
        }

        /// <summary>
        /// Sums multiples of 'multiple' up to 'limit' mathematically
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="multiple"></param>
        /// <returns>sum</returns>
        public static int SumMultiplesOf_Mathematically(int limit, int multiple)
        {
            return multiple * (((limit - 1) / multiple) * ((limit - 1) / multiple + 1)) / 2;
        }
        #endregion
    }
}
