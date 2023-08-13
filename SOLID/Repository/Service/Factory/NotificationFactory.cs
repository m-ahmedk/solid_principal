using SOLID.Repository.Interface;
using SOLID.Repository.Service.DIP;

namespace SOLID.Repository.Service.Factory
{
    public class NotificationFactory : IInstanceFactory<INotification>
    {
        private IEnumerable<INotification> _notifications;

        NotificationFactory(IEnumerable<INotification> notifications)
        {
            _notifications = notifications;
        }

        // token return based on implementation selected
        public INotification GetInstance(string token)
        {
            return token switch
            {
                "Email" => this.GetService(typeof(EmailNotification)),
                "SMS" => this.GetService(typeof(SMSNotification)),
                _ => throw new InvalidOperationException()
            }; 
        }

        // return implementation
        public INotification GetService(Type type)
        {
            return _notifications.FirstOrDefault(x => x.GetType() == type)!;
        }

    }
}
