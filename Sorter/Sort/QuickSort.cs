using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter.Sort
{
    public class QuickSort<T>:AlgorithmBase<T> where T:IComparable
    {
        public override void Makesort()
        {
            Quicksort(0,Items.Count-1);   
        }


        private int Partition(int a, int b)
        {
            int i = a;
            for (int j = a; j <= b; j++)         
            {
                if (Compare(j,b) <= 0)  
                {
                    Swap(i, j);                  
                    i++;                         
                }
            }
            return i - 1;                        
        }

        private   void Quicksort(int start, int end) 
        {                                       
            if (start >= end) return;
            int c = Partition( start, end);
            Quicksort( start, c - 1);
            Quicksort(c + 1, end);
        }

    }
}
