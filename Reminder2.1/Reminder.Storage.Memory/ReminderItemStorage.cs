using System;
using System.Collections.Generic;
using System.Linq;

namespace Reminder.Storage.Memory
{
    public class ReminderItemStorage : IReminderItemStorage
    {
        private Dictionary<Guid, ReminderItem> _items;

        public ReminderItemStorage()
        {
            _items = new Dictionary<Guid, ReminderItem>();
        }

        public void Add(ReminderItem item)
        {
            var key = item.Id;
            _items.Add(key, item);
        }

        public void Delete(Guid id)
        {
            _items.Remove(id);
        }

        public ReminderItem Find(Guid id)
        {
            ReminderItem item = _items[id];
            return item;
        }

        public ReminderItem[] FindByDateTime(DateTimeOffset dateTime)
        {            
            dateTime = DateTime.Now;
            List<ReminderItem> reminders = new List<ReminderItem>() { };

            foreach (ReminderItem item in _items.Values)
            {
                if (item.DateTimeUtc == DateTime.Now)
                {
                    reminders.Add(item);
                }

            }
            ReminderItem[] reminders1 = reminders.ToArray();
            return reminders1;
        }
       
        public void Update(ReminderItem item)
        {
            item.Id = Guid.NewGuid();
        }
    }
}
