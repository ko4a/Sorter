using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sorter.Sort
{
   public class AlgorithmBase<T> where T:IComparable
    {
        public int SwapCount { get; set; } = default;
       

        public List<T> Items { get; set; } = new List<T>();

        protected void Swap (int FirstPosition, int SecondPosition)
        {
            if(FirstPosition< Items.Count && SecondPosition < Items.Count)
            {
                var tmp = Items[FirstPosition];
                Items[FirstPosition] = Items[SecondPosition];
                Items[SecondPosition] = tmp;
                ++SwapCount;
            }
        }


        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwapCount = 0;
            timer.Start();
            Makesort();
            timer.Stop();
            return timer.Elapsed;

        }


        public virtual void Makesort()
        {
            Items.Sort();
        }


    }
}
