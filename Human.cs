using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_13._02._2023
{
    abstract internal class Human
    {
        private string name;
        private string age;

        public Human() { }
        public Human(string name, string age) {
            this.name = name;
            this.age = age;
        }

        public virtual void Enter() {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Console.ReadLine();
        }
        public virtual void Print() {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }

    }
}
