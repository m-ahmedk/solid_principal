using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOLID.Repository.Interface;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SOLID.Repository.Service.SRP
{
    // User only registers
    // Validate or send email is not relevant to User

    public class UserService : Controller
    {
        EmailService _emailService;
        AppDBContext _dbContext;

        public UserService(AppDBContext dbContext, EmailService emailService)
        {
            _dbContext = dbContext;
            _emailService = emailService;
        }

        // user registers
        public async Task UserRegisters(string email, string password)
        {
            try
            {
                // email validation
                if (!_emailService.ValidateEmail(email))
                {
                    throw new ValidationException("Email is not valid");
                }

                var user = new User(email, password);
                _dbContext.Add(user);
                await _dbContext.SaveChangesAsync();

                // send email
                await _emailService.SendEmail(email);
            }
            catch (Exception ex)
            {

            }
        }

    }
}
