using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLogicJaggedArray;

namespace ClassLibraryJaggedArrayNunit
{
    public class ComparerMinLineDesc : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a.MinLine() < b.MinLine())
                return 1;
            if (a.MinLine() > b.MinLine())
                return -1;
            else
                return 0;
        }
    }
}
