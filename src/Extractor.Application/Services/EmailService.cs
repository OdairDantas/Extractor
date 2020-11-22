using Extractor.Application.Extensions;
using System.Collections.Generic;

namespace Extractor.Application.Services
{
    public class EmailService: IEmailService
    {
        public List<string> ObterEmail(string value)
        {
            return value.Sterilize().ExtrairEmail();
        }
    }
}
