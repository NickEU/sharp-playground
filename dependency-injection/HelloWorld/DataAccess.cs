namespace HelloWorld
{
    public interface IDataAccess
    {
        void Store(string userName, string password);
    }
    public class DataAccess : IDataAccess
    {
        public void Store(string userName, string password)
        {
            // write the data to the DB
        }
    }
}