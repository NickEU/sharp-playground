using System;

namespace HelloWorld
{
    public interface IBusiness
    {
        void SignUp(string userName, string password);
    }
    
    public abstract class Business : IBusiness
    {
        protected readonly IDataAccess DataLayer;
        protected string UserName;

        protected Business(IDataAccess dataLayer)
        {
            DataLayer = dataLayer;
        }

        public virtual void SignUp(string userName, string password)
        {
            DataLayer.Store(userName, password);
        }

        protected void AnnounceTestingSuccess()
        {
            AnnounceTestingSuccess(UserName);
        }
        protected void AnnounceTestingSuccess(string userName)
        {
            Console.WriteLine($"{GetType().Name} Successfully validated user data for {userName}!");
        }
    }

    public class BusinessV1 : Business
    {
        public BusinessV1(IDataAccess dataLayer) : base(dataLayer)
        {
        }

        public override void SignUp(string userName, string password)
        {
            // some custom validation takes place
            UserName = userName;
            AnnounceTestingSuccess();
            base.SignUp(userName, password);
        }
    }

    public class BusinessV2 : Business
    {
        public BusinessV2(IDataAccess dataLayer) : base(dataLayer)
        {
        }

        public override void SignUp(string userName, string password)
        {
            // validate user data
            AnnounceTestingSuccess(userName);
            base.SignUp(userName, password);
        }
    }
}