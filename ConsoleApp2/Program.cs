using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vali kujund ja kirjuta konsooli");

            Console.WriteLine("\n1. Teemant");
            Console.WriteLine("2. Kolmnurk");


            string shape = Console.ReadLine();

            switch (shape)
            {
                case "teemant":
                    Diamond();
                    break;

                case "kolmnurk":
                    Triangle();
                    break;

                default:
                    Console.WriteLine("\nVale. Valikut ei tehtud.");
                    break;
            }
            Console.ReadKey();
        }

        private static void Diamond()
        {
            double i, j, diamond, count;

            Console.WriteLine("\nSisesta teemanti raadiuse mõõtühik sentimeetrites");
            diamond = double.Parse(Console.ReadLine());

            Console.WriteLine("Ringi ümbermõõt: " + 2 * Math.PI * diamond);
            Console.WriteLine("Ringi pindala: " + Math.PI * (diamond * diamond));

            for (i = 0; i <= diamond; i++)
            {
                for (j = 1; j <= diamond - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (i = diamond - 1; i >= 1; i--)
            {
                for (j = 1; j <= diamond - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        private static void Triangle()
        {
            Console.WriteLine("\nSisesta võrdkülgse kolmnurga külje pikkus sentimeetrites");

            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("\nSisesta võrdkülgse kolmnurga kõrguse pikkus sentimeetrites");

            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Kolmnurga ümbermõõt: " + 3 * length);
            Console.WriteLine("Kolmnurga pindala: " + (length * height) / 2);

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length * 2 - 1; column++)
                {
                    string mark = "";

                    if (row == length)
                    {
                        mark = "*";
                    }
                    else if (row + column >= length + 1 && column - length + 1 <= row)
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}