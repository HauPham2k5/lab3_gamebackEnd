﻿using Microsoft.Identity.Client;

namespace ServerGame107.Models
{
    public class EmailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
         public string Message { get; set; }
    }
}
