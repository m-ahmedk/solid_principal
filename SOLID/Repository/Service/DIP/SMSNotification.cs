using SOLID.Repository.Interface;

namespace SOLID.Repository.Service.DIP
{
    public class SMSNotification : INotification
    {
        public async Task sendNotification(string from, string body)
        {
            // implement sms notification module
        }

    }
}
