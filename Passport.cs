using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_13._02._2023
{
    abstract internal class Passport
    {
        private string name;
        private string surname;
        private string country;
        private string number_of_pass;

        public Passport() { }
        public Passport(string n, string s, string c, string nop) {
            name = n;
            surname = s;
            country = c;
            number_of_pass = nop;
        }

        public virtual void Enter() {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            surname = Console.ReadLine();
            Console.Write("Enter your county: ");
            country = Console.ReadLine();
            Console.Write("Enter your passport number: ");
            number_of_pass = Console.ReadLine();
        }
        public virtual void Print() {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Country: {country}");
            Console.WriteLine($"Passport number: {number_of_pass}");
        }

    }
}
