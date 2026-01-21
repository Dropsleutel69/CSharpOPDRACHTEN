using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpOPDRACHTEN
{
    internal class Opdracht8
    {          
        public void Start()
        {
            Character speler1 = new Character("Ridder", 10, 6);
            Character speler2 = new Character("Tovenaar", 7, 5);
            Character speler3 = new Character("Koning", 43, 11);

            List<Character> charachter = new List<Character> { speler1, speler2, speler3 };
            foreach (Character player in charachter)
            {
                player.ShowStats();
            }
        }
        public class Character
        {
            public string Name;
            public int Level;
            public int Lifes;

            public Character(string name, int level, int lifes)
            {
                Name = name;
                Level = level;
                Lifes = lifes;

            }
            public void ShowStats()
            {
                Console.WriteLine("Hallo speler jij bent " + Name + " en je bent level " + Level + " en je hebt nog " + Lifes + " levens over.");
            }

        }
    }
}
