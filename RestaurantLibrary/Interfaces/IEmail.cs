namespace RestaurantLibrary.Interfaces
{
    public interface IEmail
    {
        void SendEmail(string emailAddress, string buttonName);
    }
}