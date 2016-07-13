using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLogicJaggedArray;

namespace ClassLibraryJaggedArrayNunit
{
    public class CompareSumLine : ICustomComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a.SumLine() > b.SumLine())
                return 1;
            if (a.SumLine() < b.SumLine())
                return -1;
            else
                return 0;
        }
    }
}
