using SOLID.Repository.Interface;

namespace SOLID.Repository.Service.DIP
{
    public class EmailNotification : INotification
    {
        public async Task sendNotification(string from, string body)
        {
            // implement email notification module
        }
    }
}
