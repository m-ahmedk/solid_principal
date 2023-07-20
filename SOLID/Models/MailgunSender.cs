using System;
using System.IO;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;
using SOLID.Repository.Abstract_Classes;

namespace SOLID.Models
{
    public class MailgunSender : MailgunBaseController
    {
        public override string apikey { get; set; }
        public override string domain { get; set; }
        public override string from { get; set; }

        IConfiguration configuration;

        public MailgunSender(IConfiguration _configuration)
        {
            configuration = _configuration;

            this.apikey = configuration.GetSection("Mailgun:ApiKey").Value;
            this.domain = configuration.GetSection("Mailgun:Domain").Value;
            this.from = configuration.GetSection("Mailgun:From").Value;
        }

        public override bool SendMessage()
        {
            try
            {
                var client = new RestClient(new RestClientOptions("https://api.mailgun.net/v3"));

                RestRequest request = new RestRequest();
                request.AddParameter("domain", domain, ParameterType.UrlSegment);
                request.Resource = "{domain}/messages";
                request.AddParameter("from", from);
                request.AddParameter("to", "bar@example.com");
                request.AddParameter("subject", "Hello");
                request.AddParameter("text", "Testing some Mailgun awesomness!");

                request.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(apikey)));

                request.Method = Method.Post;
                client.Execute(request);

                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
    }

}
