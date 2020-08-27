namespace NameSorter.Repository
{
    public class NameRepositoryFactory
    {
        public static INameRepository GetNameRepositoryObj()
        {
            return new NameRepository();
        }
    }
}
