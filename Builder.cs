using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_13._02._2023
{
    internal class Builder : Human
    {
        private int crew;

        public Builder() { }
        public Builder(int c) {
            crew = c;
        }

        public override void Enter() {
            base.Enter();
            Console.Write("Enter amount of crew: ");
            string c = Console.ReadLine();
            crew = Convert.ToInt32(c);
        }
        public override void Print() { 
            base.Print();
            Console.WriteLine($"Crew: {crew}");
        }

    }
}
