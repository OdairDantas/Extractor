using Vereyon.Web;

namespace Extractor.Application.Extensions
{
    public static class Sanitizer
    {
        public static string Sterilize(this string value)
        {

            var sanitizer = new HtmlSanitizer();
            return sanitizer.Sanitize(value);

        }
    }
}
