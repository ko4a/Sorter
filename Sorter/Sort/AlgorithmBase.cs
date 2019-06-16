using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sorter.Sort
{
   public class AlgorithmBase<T> where T:IComparable
    {
        public int SwapCount { get; set; } = default;
        public int CompareCount { get; set; } = default;

        public event EventHandler<Tuple<int,int>> CompareEvent;
        public event EventHandler<Tuple<int, int>> SwapEvent;

        public List<T> Items { get; set; } = new List<T>();

        protected void Swap (int FirstPosition, int SecondPosition)
        {
            
            if(FirstPosition< Items.Count && SecondPosition < Items.Count)
            {
                SwapEvent?.Invoke(this,new Tuple<int, int>(FirstPosition,SecondPosition));
                var tmp = Items[FirstPosition];
                Items[FirstPosition] = Items[SecondPosition];
                Items[SecondPosition] = tmp;
                ++SwapCount;
            }
        }


        public int Compare(int firstIndex, int secondIndex )
        {
            CompareEvent?.Invoke(this, new Tuple<int, int>(firstIndex,secondIndex));
            CompareCount++;
            return Items[firstIndex].CompareTo(Items[secondIndex]);
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
