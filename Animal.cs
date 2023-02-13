using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_13._02._2023
{
    abstract internal class Animal
    {
        private string name;
        private string type;
        private string size;

        public Animal() { }
        public Animal(string type, string size) { 
            this.type = type;
            this.size = size;
        }

        public virtual void Enter() {
            Console.Write("Enter name of animal: ");
            name = Console.ReadLine();
            Console.Write("Enter type of animal: ");
            type = Console.ReadLine();
            Console.Write("Enter size of animal: ");
            size = Console.ReadLine();  
        }
        public virtual void Print() {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Size: {size}");
        }
    }
}
