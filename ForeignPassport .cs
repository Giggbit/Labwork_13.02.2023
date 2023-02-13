using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_13._02._2023
{
    internal class ForeignPassport : Passport
    {
        private string number_of_fpass;
        private string visa;

        public ForeignPassport() { }
        public ForeignPassport(string number_of_fpass, string visa) {
            this.number_of_fpass = number_of_fpass;
            this.visa = visa;
        }

        public override void Enter() {
            base.Enter();
            Console.Write("Enter foreign pass number: ");
            number_of_fpass = Console.ReadLine();
            Console.Write("Enter visa: ");
            visa = Console.ReadLine();
        }
        public override void Print() {
            base.Print();
            Console.WriteLine($"Foreign pass number: {number_of_fpass}");
            Console.WriteLine($"Visa: {visa}");
        }
    }
}
