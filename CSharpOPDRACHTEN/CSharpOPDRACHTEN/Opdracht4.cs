     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOPDRACHTEN
{
    internal class Opdracht4
    {
        public void Start()
        {
            Console.WriteLine("Wanneer ben je geboren? (dd-mm-jjjj)");
            string input = Console.ReadLine();
            DateTime geboortedatum = DateTime.ParseExact(input, "dd-MM-yyyy", null);

            int leeftijd = BerekenLeeftijd(geboortedatum);
            Console.WriteLine("je leeftijd is: " + leeftijd);

            if (leeftijd >= 18)
            {
                Console.WriteLine("Je mag stemmen!");
            }
            else
            {
                Console.WriteLine("Je mag nog niet stemmen!");
            }

        }

        public int BerekenLeeftijd(DateTime geboortedatum)
        {
            DateTime vandaag = DateTime.Today;
            int leeftijd = vandaag.Year - geboortedatum.Year;

            if (vandaag < geboortedatum.AddYears(leeftijd))
            {
                leeftijd--;
            }
            return leeftijd;
        }
    }
}

