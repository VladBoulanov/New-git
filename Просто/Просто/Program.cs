using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Просто
{
    class Program
    {
        static void Main(string[] args)
        {
            var Doc = new BaseDocument(number:23346,title:"Passport2");
            var Pas = new Passport(number:8759);
            Doc.IssueDate = DateTimeOffset.Parse("15.03.2015");
            Pas.Title = "Pasport";
            Pas.Country = "Russia";
            Pas.PersonName = "Igor";
            Doc.WriteToConsole();
            Pas.WriteToConsole();
        }
    }
    public class BaseDocument
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public DateTimeOffset IssueDate { get; set; }
        public virtual string Description { get; } = "{1} {2:d} {3}";
        public void WriteToConsole()
        {
            Console.WriteLine($"Title:{Title}, Number:{Number}, IssueDate:{IssueDate}",Description);
        }
        public BaseDocument(int number,string title)
        {
            Number = number.ToString();
            Title = title;
        }
    }
    public class Passport:BaseDocument
    {
        public string Country { get; set; }
        public string PersonName { get; set; }
        public override string Description { get; } = "{1} {2:d} {3} {4} {5}";
        public Passport(int number) : base(number, title:"Passport2")
        {
            
        }
        public void ChangeIssueDate(DateTimeOffset newIssueDate)
        {
            Passport[] passports = new Passport[5];
            BaseDocument[] baseDocuments = new BaseDocument[3];
            passports[0].Number = "8759";
            baseDocuments[0].Number = "23346";
            baseDocuments[0].IssueDate = DateTimeOffset.Parse("15.03.2015");
            passports[0].PersonName = "Igor";
            baseDocuments[0].Title = "Passport2";
            passports[0].Title = "Passport";
            passports[0].IssueDate = DateTimeOffset.Parse("23.06.2010");
            passports[0].Country = "Russia";
            for (int i=0;i<9;i++)
            {
                if (i is Passport)
                {
                    passports[0].IssueDate = DateTimeOffset.Parse("23.04.2020");
                }
            }
        }
    }
}
