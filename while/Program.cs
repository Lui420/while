using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //ovning 1
            int n = 1;
            while (n < 101) 
            {
                Console.WriteLine(n);
                n++;
            }

            //ovning 2
            Console.WriteLine("Mata in Lösenordet");
            var inmatat = Console.ReadLine();
            while (inmatat != "dinmamma")
            {
                Console.Write("Mata in igen: ");
                inmatat = Console.ReadLine();

                    }


            //ovning 2.1
            int i = 1;
            while (i++ < 10)
            {
                Console.WriteLine(i);
            }

            //ovning 2.2
            int f = 10;
            while (f >= 1) 
            
            {
                Console.WriteLine(f);
                f--;
            }

            //ovning2.3
            while (true)

            {
                Console.WriteLine("Tryck CTRL-C för att bryta);
               
            }
            */

            //ovning 2.4
            Console.WriteLine("Gissa Talet mellan 1-100");
            var inmatat2 = Console.ReadLine();
            while (inmatat2 != "69")
             

            {
                Console.Write("Gissa igen: ");
                inmatat2 = Console.ReadLine();

            }

            Console.ReadLine();
            
        }
    }
}
