﻿namespace PizzaStore___UML1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Designing the italian color logo
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Velkommen til Big Mammas Pizza :D ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                                  ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("De bedste pizzaer i hele landet!!!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            //Pizza menu list
            Console.WriteLine("nr. 1:  - Margherita-pizza + Pepsi til 81.25kr.");
            Console.WriteLine();
            Console.WriteLine("nr. 2:  - Greek-pizza + Cola til 118.75kr.");
            Console.WriteLine();
            Console.WriteLine("nr. 3:  - Salat-pizza + Fanta til 106.25kr.");
            Console.WriteLine();
            Console.WriteLine("For at bestille - indtast tallet af det nummer tilhørende menuen du ønsker");
            Console.WriteLine("Alle vores priser er inkl moms.");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            //Start() method
            Menu order = new Menu();
            order.Start();
            Console.ReadKey();
        }
    }
}
