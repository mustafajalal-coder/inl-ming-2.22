using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inläming_2._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur långt hoppade elin ( i meter)? ");
            double elinshopp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hur långt hoppade alma (i meter) ");
            double almashopp = Convert.ToDouble(Console.ReadLine());

            if (elinshopp > almashopp)
            {
                double skillnad = elinshopp - almashopp;

                Console.WriteLine($"elin hoppade {skillnad} meter längre än alma.");








            }



        }
    }
}
