using Microsoft.AspNetCore.Mvc;
using SOLID.Repository.Interface;
using SOLID.Repository.Service.Factory;

namespace SOLID.Controllers.DIP
{
    public class NotificationController : Controller
    {
        private readonly NotificationFactory _notifictionFactory;

        public NotificationController(NotificationFactory notificationFactory)
        {
            _notifictionFactory = notificationFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(string recipient, string message)
        {
            var emailNotification = _notifictionFactory.GetInstance("Email");

            if (emailNotification != null)
            {
                emailNotification.sendNotification(recipient, message);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SendSMS(string recipient, string message)
        {
            var smsNotification = _notifictionFactory.GetInstance("SMS");

            if (smsNotification != null)
            {
                smsNotification.sendNotification(recipient, message);
            }

            return RedirectToAction("Index");
        }
    }
}
