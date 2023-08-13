namespace SOLID.Repository.Interface
{
    public interface INotification
    {
        public Task sendNotification(string from, string body);
    }
}
