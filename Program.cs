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

        }
    }
}
