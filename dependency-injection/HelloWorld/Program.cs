namespace HelloWorld
{
    public class Program
    {
        private static void Main()
        {
            new UserInterface(new BusinessV1(new DataAccess())).GetData();
            new UserInterface(new BusinessV2(new DataAccess())).GetData();
        }
    }
}
