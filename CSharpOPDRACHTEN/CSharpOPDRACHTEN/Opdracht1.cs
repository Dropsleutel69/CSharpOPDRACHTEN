using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOPDRACHTEN
{
    internal class Opdracht1
    {
       public void Start()
        {
            Console.WriteLine("Wat is uw naam?");
            string naam = Console.ReadLine();
            Console.WriteLine("Hoe oud bent u?");
            string leeftijd = Console.ReadLine();
            Console.WriteLine($"Hoi {naam}, je bent {leeftijd} jaar oud!");
        }
    }
}
