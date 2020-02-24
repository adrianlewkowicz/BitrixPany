using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Portfolio.API.Services;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace Portfolio.API.Controllers
{
    // http://localhost:5000
  
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailSender _emailSender;

        public EmailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost]
        public IActionResult SendEmail()
        {
            var toAddress = HttpContext.Request.Form["toAddress"].FirstOrDefault();
            var subject = HttpContext.Request.Form["subject"].FirstOrDefault();
            var body = HttpContext.Request.Form["body"].FirstOrDefault();

            _emailSender.Send(toAddress,subject,body);
           return Ok(200);
        }
    }
}