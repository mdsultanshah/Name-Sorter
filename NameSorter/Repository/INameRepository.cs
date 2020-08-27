using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public interface INameRepository
    {
        IEnumerable<string> ReadFromTextFile(string filePath);

        void WriteToTextFile(string filePath, IEnumerable<string> names);
    }
}
