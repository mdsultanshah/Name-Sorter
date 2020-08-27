using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Sort
{
    public class SortName : ISortName
    {
        public IEnumerable<string> SortByLastName(IEnumerable<string> names)
        {
            return new SortedSet<string>(names, new SortByLastName());
        }
    }
}
