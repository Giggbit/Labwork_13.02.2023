using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_13._02._2023
{
    internal class Sailor : Human
    {
        private string ship;

        public Sailor() { }
        public Sailor(string s) {
            ship = s;
        }

        public override void Enter() {
            base.Enter();
            Console.Write("Enter your ship: ");
            ship = Console.ReadLine();        }
        public override void Print() { 
            base.Print();
            Console.WriteLine($"Ship: {ship}");
        }
    }
}
