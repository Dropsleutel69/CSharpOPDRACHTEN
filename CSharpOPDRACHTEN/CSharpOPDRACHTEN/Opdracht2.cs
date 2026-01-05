using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOPDRACHTEN
{
    internal class Opdracht2
    {
        //badkamer keuken slaapkamer
        //als gebruiker badkamer typt dan bericht: Welkom in de badkamer!
        public void Start()
        {
            Console.WriteLine("kies een kamer: badkamer, keuken of slaapkamer");
            string input = Console.ReadLine();
            if (input == "keuken")
            {
                Console.WriteLine("welkom in de keuken, eetsmakelijk!");
            }
            if (input == "badkamer")
            {
                Console.WriteLine("Welkom in de badkamer, voorzichtig doen in de douche!");
            }
            if (input == "slaapkamer")
            {
                Console.WriteLine("Welkom in de slaapkamer, slaaplekker!");
            }
        }
        
    }
}
