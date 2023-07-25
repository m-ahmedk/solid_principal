using SOLID.Models;
using SOLID.Repository.Interface;

namespace SOLID.Repository.Service.SRP
{
    public class EmailService
    {
        MailgunSender _mailgunSender;

        public EmailService(MailgunSender mailgunSender)
        {
            _mailgunSender = mailgunSender;
        }

        public async Task<bool> SendEmail(string email)
        {
            return _mailgunSender.SendMessage(email);
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains('@');
        }

    }
}
