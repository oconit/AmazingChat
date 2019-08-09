using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingChatWebApp.Models
{
    public class Profile 
    {
        public Guid Id { get; set; }
        public String Username { get; set; }
        public String Color { get; set; }
        public String PicUrl { get; set; }

    }
}