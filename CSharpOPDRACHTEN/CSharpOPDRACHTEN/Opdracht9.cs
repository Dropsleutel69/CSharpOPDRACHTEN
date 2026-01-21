using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOPDRACHTEN
{
    internal class Opdracht9
    {
        public void Start()
        {
            Weapon spear = new Weapon(10, "Goude prikker", "zwaard");
            Weapon glock = new Weapon(15, "Water pistool", "geweer");

            List<Weapon> Weapon = new List<Weapon> { spear, glock };
            foreach(Weapon weapon in Weapon)
            {
                weapon.ShowStats();
            }

            glock.UpgradeItem(5);
            spear.UpgradeItem(8);

            Console.WriteLine("Items na de upgrade: ");
            glock.ShowStats();
            spear.ShowStats();

        } 
    }
    public class Weapon
    {
        public int Damage;
        public string Name;
        public string Type;

        public Weapon(int damage, string name, string type)
        {
            Damage = damage;
            Name = name;
            Type = type;
        }

        public void ShowStats()
        {
            Console.WriteLine(Name + " doet " + Damage + " damage en het is een " + Type);
        }

        public void UpgradeItem(int DamageToAdd)
        {
            Damage += DamageToAdd; 

        }
        
    }
}
