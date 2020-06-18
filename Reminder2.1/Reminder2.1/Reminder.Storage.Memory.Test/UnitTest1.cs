using NUnit.Framework;

namespace Reminder.Storage.Memory.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            var storage = new ReminderItemStorage();
            storage.Add(null);
        }
        public void Test2()
        {
            var storage = new ReminderItemStorage();
            storage.Find.Assert.NotEmpty(item);
        }
        public void Test3()
        {
            var storage = new ReminderItemStorage();
            storage.FindByDateTime.Assert.NotEmpty(key);
        }
    }
}