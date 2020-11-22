using System.Collections.Generic;

namespace Extractor.Application.Services
{
    public interface IEmailService
    {
        List<string> ObterEmail(string value);
    }
}