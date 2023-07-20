namespace SOLID.Repository.Interface
{
    public interface IEmailService
    {
        public bool SendEmail(string email);
        public bool ValidateEmail(string email);
    }
}
