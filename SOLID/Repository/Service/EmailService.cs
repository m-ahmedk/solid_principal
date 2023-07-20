using SOLID.Models;
using SOLID.Repository.Interface;

namespace SOLID.Repository.Service
{
    public class EmailService : IEmailService
    {
        MailgunSender _mailgunSender;

        public EmailService(MailgunSender mailgunSender)
        {
            _mailgunSender = mailgunSender;
        }

        public bool SendEmail(string email)
        {
            return _mailgunSender.SendMessage();
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains('@');
        }

    }
}
