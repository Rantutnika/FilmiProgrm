using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Filmi11a
{
    internal class ICompareFilmNames : IComparer<Filmi>
    {
        public int Compare(Filmi x, Filmi y)
        {  
          return x.Name.CompareTo(y.Name);
        }
    }
}
