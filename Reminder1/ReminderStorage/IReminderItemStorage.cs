using System;


namespace Reminder.Storage
{
    public interface IReminderItemStorage
    {
        void Add(ReminderItem item);
        void Delete(Guid id);
        void Update(ReminderItem item);
        ReminderItem Find(ReminderItem item);
        Guid[] Find2(DateTimeOffset dateTime);
        ReminderItem[] Find3(DateTimeOffset dateTime);
        ReminderItem[] FindByDateTime(DateTimeOffset dateTime);
    }
}
