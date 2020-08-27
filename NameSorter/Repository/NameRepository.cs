using System.Collections.Generic;
using System.IO;

namespace NameSorter.Repository
{
    public class NameRepository : INameRepository
    {
        public IEnumerable<string> ReadFromTextFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        public void WriteToTextFile(string filePath,IEnumerable<string> names)
        {
            // Write names to text file
            File.WriteAllLines(filePath, names);
        }
    }
}
