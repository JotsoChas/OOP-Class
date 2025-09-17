using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Person
{
    public class Person
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int GetAge()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - BirthYear;
        }



        public Person(string firstname, string lastname, int birthyear)
        {
            FirstName = firstname;
            LastName = lastname;
            BirthYear = birthyear;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} och är född {BirthYear} och är {GetAge()} år gammal");
        }
    }
}
