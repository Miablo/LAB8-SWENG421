using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget;
            Console.WriteLine("Enter your TV Budget: ");
            budget = Int32.Parse(Console.ReadLine());
            Retailer store = new Retailer(budget);
            store.replenishTV();
        }
    }
}
