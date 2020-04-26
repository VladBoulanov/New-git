using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Reminderltem> list = new List<Reminderltem>();
            {
                PhoneRemanderlthem phone=new PhoneRemanderlthem();
                ChatReminderlthem chat = new ChatReminderlthem();
                ChatReminderlthem account = new ChatReminderlthem();
                list.Add(phone);
                list.Add(chat);
                list.Add(account);              
                phone.WriteProperties();
                chat.WriteProperties();
                account.WriteProperties();
            }
            Reminderltem da = new Reminderltem();
            da.AlarmDate = DateTimeOffset.Parse(Console.ReadLine());
            da.AlarmMessage = Console.ReadLine();
            da.WriteProperties();
            
        }
    }
    public class Reminderltem
    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public Reminderltem()
        {
            this.AlarmDate = AlarmDate;
            this.AlarmMessage = AlarmMessage;
        }
        public TimeSpan TimeToAlarm
        {
            get
            {
                return DateTimeOffset.Now - AlarmDate;
            }
        }
        public bool IsOutdated
        {
            get
            {
                if(TimeToAlarm >= TimeSpan.Zero)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }
        public virtual void WriteProperties()
        {
            Console.WriteLine("public DateTimeOffset AlarmDate:{0}", AlarmDate);
            Console.WriteLine("AlarmMessage:{0}", AlarmMessage);
            Console.WriteLine("TimeToAlarm:{0}", TimeToAlarm);
            Console.WriteLine("IsOutdated:{0}", IsOutdated);
        }
        
    }
    public class PhoneRemanderlthem:Reminderltem
    {
        public string PhoneNumber { get; set; }
        public PhoneRemanderlthem()
        {
            this.AlarmDate = AlarmDate;
            this.AlarmMessage = AlarmMessage;
            this.PhoneNumber = PhoneNumber;
        }
        public override void WriteProperties()
        {
            Console.WriteLine("public DateTimeOffset AlarmDate:{0}", AlarmDate);
            Console.WriteLine("public string AlarmMessage:{0}", AlarmMessage);
            Console.WriteLine("TimeToAlarm:{0}", TimeToAlarm);
            Console.WriteLine("IsOutdated:{0}", IsOutdated);
            Console.WriteLine("public string PhoneNumber:{0}", PhoneNumber);
        }
    }
    public class ChatReminderlthem:Reminderltem
    {
        public string ChatName { get; set; }
        public string AccountName { get; set; }
        public ChatReminderlthem()
        {
            this.AlarmDate = AlarmDate;
            this.AlarmMessage = AlarmMessage;
            this.ChatName = ChatName;
            this.AccountName = AccountName;
        }
        public override void WriteProperties()
        {
            Console.WriteLine("public DateTimeOffset AlarmDate:{0}", AlarmDate);
            Console.WriteLine("public string AlarmMessage:{0}", AlarmMessage);
            Console.WriteLine("TimeToAlarm:{0}", TimeToAlarm);
            Console.WriteLine("IsOutdated:{0}", IsOutdated);
            Console.WriteLine("public string ChatName:{0}", ChatName);
            Console.WriteLine("public string AccountName:{0}", AccountName);
        }
    }
}
