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

        public Elf(string name,int age,double height,string res)
        {
            Name = name;
            this.age = age;
            this.height = height;
            Residence = res;
        }

        public void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("#####################");
            Console.WriteLine($"Name: {Name}\nAge: {age}\nHeight: {height}\nResidence: {Residence}");
            Console.WriteLine("#####################");
            Console.WriteLine("");
            Console.ResetColor();
        }

        public void Birthday()
        {
            age++;
        }
    }
}