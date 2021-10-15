using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            int budget;
            do
            {
                Console.WriteLine("\nEnter your TV Budget: ");
                budget = Int32.Parse(Console.ReadLine());
                Retailer store = new Retailer(budget);
                Console.WriteLine("\n");
                store.replenishTV();

                Console.WriteLine("\n\nWould you like to enter a new budget? \n(0) Yes (1) No: ");
                userInput = Int32.Parse(Console.ReadLine());

            } while (userInput != 1);

            Console.WriteLine("\n\nThank you for shopping. Goodbye! \n\n\n");

        }
    }
}
