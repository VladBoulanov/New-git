using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderItem
{
    public class ReminderItem
    {
        public ReminderItem(Guid id, string tittle, string message, DateTimeOffset dateTimeUtc, Guid userId, ReminderItemStatus status)
        {
            Id = id;
            Tittle = tittle;
            Message = message;
            DateTimeUtc = dateTimeUtc;
            UserId = userId;
            Status = status;
        }

        public Guid Id { get; set; }
        public string Tittle { get; set; }
        public string Message { get; set; }
        public DateTimeOffset DateTimeUtc { get; set; }
        public Guid UserId { get; set; }

        public ReminderItemStatus Status { get; set; }
        
    }
}
