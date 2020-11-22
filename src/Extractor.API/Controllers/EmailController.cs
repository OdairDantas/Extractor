using Extractor.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Extractor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult ExtrairEmail([FromBody]string texto)
        {
           var emails = _emailService.ObterEmail(texto);

            if (!emails.Any()) BadRequest();


            return Ok(emails);
        }
    }
}
