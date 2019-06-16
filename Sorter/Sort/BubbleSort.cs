using System;

namespace Sorter.Sort
{
    public class BubbleSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Makesort()
        {
            if (Items.Count < 2)
                return;

            bool SwapIteration = false;

            for (int i = 1; i < Items.Count; i++)
            {
                
                
                if (Compare(i-1,i) > 0)
                {
                    Swap(i, i - 1);
                    SwapIteration = true;
                }
                if (i == Items.Count - 1 && SwapIteration)
                {
                    SwapIteration = false;
                    i = 0;
                }

            }


        }
    }
}
