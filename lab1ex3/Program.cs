using System;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
            tastaura */

            Console.WriteLine("This program will print the digit number of a number");
            Console.WriteLine("Type the number");

            int yourNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The last digit of your number is " + yourNumber % 10);
        }
    }
}
