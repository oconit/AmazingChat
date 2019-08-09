using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingChatWebApp.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public Profile Sender { get; set; }
        public Profile Recipient { get; set; }
        public String Content { get; set; }
        public DateTime Timestamp { get; set; }
        public Boolean PublicDirect { get; set; }
        aaaa
    }
}dsd