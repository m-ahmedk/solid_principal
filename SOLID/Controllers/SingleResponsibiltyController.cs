using Microsoft.AspNetCore.Mvc;
using SOLID.Repository.Interface;
using SOLID.Repository.Service;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SOLID.Controllers
{
    public class SingleResponsibiltyController : Controller
    {
        EmailService _emailService;
        IConfiguration _configuration;

        public SingleResponsibiltyController(IConfiguration configuration, EmailService emailService) 
        { 
            _configuration = configuration;
            _emailService = emailService;
        }

        //public Task<ActionResult> UserRegisters(string email, string password)
        //{
        //    try
        //    {
        //        if (!_emailService.ValidateEmail(email))
        //        {
        //            throw new ValidationException("Email is not an email");
        //        }

        //        var user = new User(email, password);
        //        _dbContext.Save(user);
        //        emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });

        //        return View();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

    }
}
