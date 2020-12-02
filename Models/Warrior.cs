using System.Collections.Generic;
using System;

namespace Elves.Models
{
    public class Warrior : Elf
    {
        List<Weapon> BagOWeapons;
        public Warrior(string name, int age, double height, string res) : base(name, age, height, res)
        {
            BagOWeapons = new List<Weapon>{
                new Weapon("Candy Cane Sword",25),
                new Weapon("Gumdrop Slingshot",10)
            };
        }

        public void Attack(Elf target)
        {

            Random rand = new Random();

            Weapon wpn = BagOWeapons[rand.Next(0,BagOWeapons.Count)];

            Console.WriteLine($"{Name} used {wpn.Name} on {target.Name} for {wpn.Damage}!");

            target.TakeDamage(wpn.Damage);
            if(target.IsDead)
            {
                Console.WriteLine($"{Name} has obliterated {target.Name}!!  Elf blood is on his hands.");
            }
            // target.PrintInfo();
        }

        public void AddWeapon(string name, int dmg)
        {
            BagOWeapons.Add(new Weapon(name,dmg));
        }
    }
}