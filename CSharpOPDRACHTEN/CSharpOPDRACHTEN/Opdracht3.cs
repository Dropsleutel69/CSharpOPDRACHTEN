using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOPDRACHTEN
{
    internal class Opdracht3
    {
        public void Start()
        {
            Console.WriteLine("Hoe is het weer vandaag?");
            Console.WriteLine("Kies uit: zonnig, regen, bewolkt");

            string input = Console.ReadLine();

            Console.WriteLine("Hoeveel graden is het?");
            if (!double.TryParse(Console.ReadLine(), out double temperatuur))
            {
                Console.WriteLine("Ongeldige invoer, voer een getal in voor de temperatuur!");
            }

            if (input == "zonnig")
            {
                if (temperatuur >= 18)
                    Console.WriteLine("Je hebt geen jas nodig vandaag, geniet van de zon!");
                else
                    Console.WriteLine("Het is zonnig maar fris, een jas is handig.");
            }

            if (input == "regen")
            {
                if (temperatuur >= 15)
                    Console.WriteLine("Een regenjas is handig, maar het is niet koud!");
                else
                    Console.WriteLine("Het is koud en nat vandaag, trek een warme jas aan!");
            }

            if (input == "bewolkt")
            {
                if (temperatuur >= 20)
                    Console.WriteLine("Goed weer om buiten te zijn, ook zonder jas.");
                else
                    Console.WriteLine("Het is koud en bewolkt, DOE JAS AAN!!!");
            }
        }

    }
}

