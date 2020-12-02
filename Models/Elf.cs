using System;

namespace Elves.Models
{
    public class Elf
    {
        public string Name;

        private int age;

        public int Age
        {
            get
            {
                return age;
            }
        }

        private double height;

        public double Height
        {
            get
            {
                return height;
            }
        }

        public string Residence;

        protected int health;

        public int Health
        {
            get
            {
                return health;
            }
        }

        public bool IsDead
        {
            get{
                return health <=0;
            }
        }

        public Elf(string name,int age,double height,string res)
        {
            Name = name;
            this.age = age;
            this.height = height;
            Residence = res;
            health = 100;
        }

        public void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("#####################");
            Console.WriteLine($"Name: {Name}\nAge: {age}\nHeight: {height}\nResidence: {Residence}\nHealth: {health}");
            Console.WriteLine("#####################");
            Console.WriteLine("");
            Console.ResetColor();
        }

        public void Birthday()
        {
            age++;
        }

        public int TakeDamage(int dmg)
        {
            health -= dmg;
            return health;
        }
    }
}