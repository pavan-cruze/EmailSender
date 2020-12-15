using System;

namespace EmailSender
{
    public class EmailSendResult
    {
        public bool IsMessageDelivered { get; set; } = false;
        public Exception Error { get; set; }
    }
}