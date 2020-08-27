using System;
using System.Configuration;
using NameSorter.Repository;
using NameSorter.Sort;


namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // File Path 
                string readTextFilePath = ConfigurationManager.AppSettings["ReadTextFilePath"];
                string writeTextFilePath = ConfigurationManager.AppSettings["WriteTextFilePath"];

                // Abstraction
                INameRepository _NameRepository = NameRepositoryFactory.GetNameRepositoryObj();
                ISortName _SortName = SortNameFactory.GetSortNameObj();

                // Read names from text file
                var names = _NameRepository.ReadFromTextFile(readTextFilePath);

                // Sort names by last name
                var sortedNames = _SortName.SortByLastName(names);

                // Print the sorted names to screen
                Console.WriteLine(string.Join("\n", sortedNames));

                // Write names to text file
                _NameRepository.WriteToTextFile(writeTextFilePath, sortedNames);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
