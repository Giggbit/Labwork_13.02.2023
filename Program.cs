using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_13._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Human> human = new List<Human>();
            bool ans = false;
            while(ans != true) { 
                Console.WriteLine("\nChoose option:\n1) Add\n2) Exit\n");
                string a = Console.ReadLine();
                int answer = Convert.ToInt32(a);
                int i = 0;
                switch (answer) {
                    case 1:
                        Console.WriteLine("\nChoose:\n1) Builder\n2) Sailor\n3) Pilot\n");
                        a = Console.ReadLine();
                        answer = Convert.ToInt32(a);
                        switch (answer) {
                        case 1:
                            human.Add(new Builder());
                            human[i].Enter();
                            human[i].Print();
                            i++;
                            break;

                        case 2:
                            human.Add(new Sailor());
                            human[i].Enter();
                            human[i].Print();
                            i++;
                            break;

                        case 3:
                            human.Add(new Pilot());
                            human[i].Enter();
                            human[i].Print();
                            i++;
                            break;
                    }
                        break;

                    case 2:
                        ans = true;
                        break;
                }
            }
            

        }
    }
}
