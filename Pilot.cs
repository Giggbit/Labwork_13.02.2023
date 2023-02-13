using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_13._02._2023
{
    internal class Pilot : Human
    {
        private string subdivision;

        public Pilot() { }
        public Pilot(string s) {
            subdivision = s;
        }

        public override void Enter() {
            base.Enter();
            Console.Write("Enter your subdivision: ");
            subdivision = Console.ReadLine();        }
        public override void Print() { 
            base.Print();
            Console.WriteLine($"Subdivision: {subdivision}");
        }
    }
}
