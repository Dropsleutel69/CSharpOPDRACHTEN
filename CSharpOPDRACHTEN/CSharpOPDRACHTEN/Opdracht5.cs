using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOPDRACHTEN
{
    internal class Opdracht5
    {
        public void Start()
        {
            Console.WriteLine("Welke tafel wil je berekenen?");
            int tafel = int.Parse(Console.ReadLine());

            Console.WriteLine("En hoevaak wil je dit doen?");
            int tot = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= tot)
            {
                Console.WriteLine(tafel + " x " + i + " = " + (tafel * i));
                i++;
            }
        }

    }
}
