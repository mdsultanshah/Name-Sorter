using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Sort
{
    public class SortNameFactory
    {
        public static ISortName GetSortNameObj()
        {
            return new SortName();
        }
    }
}
