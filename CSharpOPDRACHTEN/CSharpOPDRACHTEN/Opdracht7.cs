using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOPDRACHTEN
{
    internal class Opdracht7
    {
        public void Start()
        {
            Random random = new Random();
            int[] teller = new int[6];

            for (int i = 0; i < 100; i++)
            {
                int worp = random.Next(1, 7);
                teller[worp - 1]++;

                Console.WriteLine($"Je hebt {worp} gegooid!");
            }
            for (int i = 0; i < teller.Length; i++)
            {
                Console.WriteLine($"De worp {i + 1} is {teller[i]} keer gegooid");
            }
        }
    }
}
