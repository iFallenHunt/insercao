using Humanizer;
using System;

namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your full name? ");
            string name = Console.ReadLine();

            Console.WriteLine("How many rooms do you have in your house? ");
            int rooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price of some poduct (separated by ,)");
            double prod = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter your Last name, age and height (all on the same line)");

            string[] complete = Console.ReadLine().Split(' ');
            string snome = complete[0];
            int age = int.Parse(complete[1]);
            double height = double.Parse(complete[2]);

            Console.WriteLine("My name is: ");
            Console.WriteLine(name);
            Console.WriteLine("My house does: ");
            Console.WriteLine(rooms);
            Console.WriteLine("The product costs: ");
            Console.WriteLine(prod);

            Console.WriteLine("My last name is: ");
            Console.WriteLine(snome);
            Console.WriteLine("My age is: ");
            Console.WriteLine(age);
            Console.WriteLine("My height is: ");
            Console.WriteLine(height);


        }
    }
}