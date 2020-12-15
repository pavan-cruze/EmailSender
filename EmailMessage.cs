using System.Collections.Generic;

namespace EmailSender
{
    public class EmailMessage
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<string> TO { get; set; }// recipients
        public List<string> CC { get; set; }// recipients
        public bool IsBodyHtml { get; set; }

    }
}