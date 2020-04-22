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
        public void WriteProperties()
        {
            Console.WriteLine("AlarmDate:{0}",AlarmDate);
            Console.WriteLine("AlarmMessage:{0}", AlarmMessage);
            Console.WriteLine("TimeToAlarm:{0}", TimeToAlarm);
            Console.WriteLine("IsOutdated:{0}", IsOutdated);
        }
        
    }
}
