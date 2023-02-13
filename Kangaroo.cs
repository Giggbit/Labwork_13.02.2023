using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_13._02._2023
{
    internal class Kangaroo : Animal
    {
        private string character;

        public Kangaroo() { }
        public Kangaroo(string character) { 
            this.character = character;
        }

        public override void Enter() {
            base.Enter();
            Console.Write("Enter character: ");
            character = Console.ReadLine();
        }
        public override void Print() {
            base.Print();
            Console.WriteLine($"Charcter: {character}");
        }
    }
}
