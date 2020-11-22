using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Extractor.Application.Extensions
{
    public static class Email
    {
        public static List<string> ExtrairEmail(this string texto)
        {
            var emails = new List<string>();
            const string MatchEmailPattern =
           @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";
            var rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var matches = rx.Matches(texto);
            foreach (Match match in matches)
                emails.Add(match.Value.ToString());

            return emails;

        }
    }
}
