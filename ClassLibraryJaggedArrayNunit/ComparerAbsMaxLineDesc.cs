using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLogicJaggedArray;

namespace ClassLibraryJaggedArrayNunit
{
    public class ComparerAbsMaxLineDesc : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a.AbsMaxLine() < b.AbsMaxLine())
                return 1;
            if (a.MaxLine() > b.MaxLine())
                return -1;
            else
                return 0;
        }
    }
}
