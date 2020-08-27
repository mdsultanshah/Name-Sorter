using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Sort
{
    public class SortByLastName : IComparer<string>
    {
        string xLastName, yLastName;

        public int Compare(string x, string y)
        {
            // Get Last name from the given name.
            if (x.LastIndexOf(" ") != -1 && y.LastIndexOf(" ") != -1)
            {
                xLastName = x.Substring(x.LastIndexOf(" ") + 1);
                yLastName = y.Substring(y.LastIndexOf(" ") + 1);

                // Compare the last name.
                int vLastName = xLastName.CompareTo(yLastName);
                if (vLastName != 0)
                {
                    return vLastName;
                }
                else
                {
                    // The last name is the same,
                    // so compare the given name.
                    return x.CompareTo(y);
                }
            }
            else
            {
                // If there is no last name,
                // so compare the given name.
                return x.CompareTo(y);
            }
        }
    }
}
