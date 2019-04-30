using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter.Sort
{
    public class CocktailSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Makesort()
        {
            int left = 0,
               right = Items.Count - 1,
               count = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;

                    if (Items[i].CompareTo(Items[i + 1]) > 0)
                        Swap(i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (Items[i - 1].CompareTo(Items[i]) > 0)
                        Swap(i - 1, i);
                }
                left++;
            }


        }
    }
}