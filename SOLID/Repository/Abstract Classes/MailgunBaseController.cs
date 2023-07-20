using Microsoft.AspNetCore.Mvc;

namespace SOLID.Repository.Abstract_Classes
{
    public abstract class MailgunBaseController
    {
        public abstract string apikey { get; set; }
        public abstract string domain { get; set; }
        public abstract string from { get; set; }
        public abstract bool SendMessage();
    }
}
