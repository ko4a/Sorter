using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter.Sort
{
    public class ShellSort<T>:AlgorithmBase<T> where T:IComparable
    {
        public override void Makesort()
        {
            var step = Items.Count / 2;

            while (step > 0)
            {
                for (int i = step; i < Items.Count; i++)
                {
                    int j = i;
                    while ((j >= step) && Items[j - step].CompareTo(Items[j])>0 )
                    {
                        Swap(j - step, j);
                        j -= step;
                    }
                }

                step /= 2;
            }
        }
    }
}
