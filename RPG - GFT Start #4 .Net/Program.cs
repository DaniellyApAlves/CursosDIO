using System;
using RPG.src.Entities;


namespace dotnet___poo
{
    class Program

    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Hero wizard = new Hero("Jennica", 23, "White Wizard");       

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            

        }
    }
}