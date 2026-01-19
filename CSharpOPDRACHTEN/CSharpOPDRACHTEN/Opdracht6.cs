using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOPDRACHTEN
{
    internal class Opdracht6
    {
        public void Start()
        {
            int maximum;

            while (true)
            {
                Console.WriteLine("Geef een maximum getal: ");
                if (int.TryParse(Console.ReadLine(), out maximum) && maximum > 0)
                {
                    break;
                }
                Console.WriteLine("Voer een geldig getal in, boven de 0");
            }

            Random random = new Random();
            int geheimGetal = random.Next(1, maximum + 1);
            int pogingen = 0;

            while (true)
            {
                Console.WriteLine($"Raad een getal tussen de 1 en {maximum}: ");
                if (!int.TryParse(Console.ReadLine(), out int gok))
                {
                    Console.WriteLine("Dat is geen geldig nummer!");
                    continue;
                }
                pogingen++;

                if (gok < geheimGetal)
                {
                    Console.WriteLine("Hoger!");
                }
                else if (gok > geheimGetal)
                {
                    Console.WriteLine("Lager!");
                }
                else
                {
                    Console.WriteLine($"Goed geraden! je hebt het gehaald in {pogingen} pogingen!");
                    break;
                }
            }
        }
    }
}
