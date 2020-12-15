using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailSender
{
    public abstract class EmailSender
    {
        public EmailSender(GmailClientInfo ClientInfo)
        {
            this.ClientInfo = ClientInfo;
        }
        protected GmailClientInfo ClientInfo { get; set; }
    }
}
