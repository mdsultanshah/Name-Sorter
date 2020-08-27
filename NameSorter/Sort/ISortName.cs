using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Sort
{
    public interface ISortName
    {
        IEnumerable<string> SortByLastName(IEnumerable<string> names);
    }
}
