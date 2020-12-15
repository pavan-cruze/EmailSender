namespace EmailSender
{
    public class GmailClientInfo
    {
        public string GmailUserEmail { get; set; }
        public string GmailUserPassword { get; set; }
        public string SMTPServerHost { get; set; } = "smtp.gmail.com";
        public int SMTPServerPort { get; set; } = 587;
    }
}