using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLogicJaggedArray
{
    public interface ICustomComparer
    {
        int Compare(int[] a, int[] b);
    }
}
