namespace PizzaStore___UML1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
               
            Console.WriteLine("Velkommen til Big Mammas Pizza");
            Console.ForegroundColor = ConsoleColor.Brown;
             Console.WriteLine("Alle vores priser er inkl moms");
            Console.WriteLine();
             Console.WriteLine("nr 1:  - Margherita-pizza + Pepsi til 81.25kr.");
            Console.WriteLine();
              Console.WriteLine("nr 2:   - Greek-pizza + Cola til 118.75kr.");
            Console.WriteLine();
            Console.WriteLine("nr 3:   - Salat-pizza + Fanta til 106.25kr.");
                Console.WriteLine("For at bestille - indtast tallet af det nummer tilhørende menuen du ønsker");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Menu order = new Menu();
            order.CustomerOrder();
            Console.ReadKey();
        }
    }
}
