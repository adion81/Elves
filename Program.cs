using System;
using Elves.Models;

namespace Elves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wonderful World of Elves!");

            Elf albert = new Elf("Fat Albert",576,5.76,"122 Shelf Ln.");
            albert.PrintInfo();
            Console.WriteLine(albert.Height);
            albert.PrintInfo();

            Keebler dhaval = new Keebler("Dhaval",450,3.45);

            dhaval.PrintInfo();

            NorthPole mitch = new NorthPole("Mitch",150,4.67);

            mitch.PrintInfo();

            Warrior Ramar = new Warrior("Ra'mar",700,7.6,"Darkness");

            while(!albert.IsDead)
            {
                Ramar.Attack(albert);
            }

            Ramar.AddWeapon("Tin of Popcorn Skulls", 30);
            Ramar.AddWeapon("Pine Tree Bazooka", 50);

            Warrior Nibbles = new Warrior("Mr. Nibbles",400,3.5,"Revenge Lane");

            Nibbles.AddWeapon("Tinsle Tosser",70);

            while(!Nibbles.IsDead && !Ramar.IsDead)
            {
                Random rand = new Random();
                int dice = rand.Next(0,20);

                if(dice % 2 == 0)
                    Nibbles.Attack(Ramar);
                else
                    Ramar.Attack(Nibbles);
            }

            

        }
    }
}
