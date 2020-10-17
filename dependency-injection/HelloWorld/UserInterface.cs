using System;

namespace HelloWorld
{
    public class UserInterface
    {
        public IBusiness BusinessLayer { get; }
        public UserInterface(IBusiness businessLayer)
        {
            BusinessLayer = businessLayer;
        }

        public void GetData()
        {
            Console.WriteLine("Enter your username: ");
            var userName = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            var password = Console.ReadLine();

            BusinessLayer.SignUp(userName, password);
            Console.WriteLine("The registration has been completed!");
        }
    }
}