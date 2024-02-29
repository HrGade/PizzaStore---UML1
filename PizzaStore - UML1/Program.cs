namespace PizzaStore___UML1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Velkommen til Big Mammas Pizza :D");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("De bedste pizzaer i hele landet!!!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("nr. 1:  - Margherita-pizza + Pepsi til 81.25kr.");
            Console.WriteLine();
            Console.WriteLine("nr. 2:  - Greek-pizza + Cola til 118.75kr.");
            Console.WriteLine();
            Console.WriteLine("nr. 3:  - Salat-pizza + Fanta til 106.25kr.");
            Console.WriteLine();
            Console.WriteLine("For at bestille - indtast tallet af det nummer tilhørende menuen du ønsker");
            Console.WriteLine("Alle vores priser er inkl moms");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Menu order = new Menu();
            order.CustomerOrder();
            Console.ReadKey();
        }
    }
}
