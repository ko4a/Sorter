using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter.Sort
{
    public class InsertSort<T>:AlgorithmBase<T> where T:IComparable
    {
        public override void Makesort()
        {
            for (int i = 1; i < Items.Count; i++)
                for (int j = i; j > 0 && Items[j-1].CompareTo(Items[j])>0; j-- ) 
                    Swap(j - 1, j);
        }
    }
}
