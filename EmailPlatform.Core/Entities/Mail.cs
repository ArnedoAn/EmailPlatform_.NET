using System;

namespace EmailPlatform.Core.Entities
{
    public class Mail
    {
        public int Id { get; set; }
        public string ToUser { get; set; } = string.Empty;
        public string FromUser { get; set; }  = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public bool State { get; set; } = false;
        public DateTime Date { get; set; } = DateTime.MinValue;
    }
}
