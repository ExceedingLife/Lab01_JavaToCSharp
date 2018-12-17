using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_JavaToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal percentProfit = .40m;
            decimal profitTotal = 0m;
            decimal total = 0m;
            string input;

            // Tell user to enter the retail price.
            Console.WriteLine("Please enter the retail price of the circuit board.");
            // Get the users input.
            input = Console.ReadLine();
            // Check to make sure the user inputed a decimal.
            if (decimal.TryParse(input, out decimal retailPrice))
            {
                // Calculate the selling price.
                total = (retailPrice * percentProfit) + retailPrice;
                // Calculate the selling profit total.
                profitTotal = total - retailPrice;
                // Display all the results.
                Console.Write("Your retail price: " + retailPrice + "\n" +
                              "Your selling price: " + total + "\n" +
                              "Your profit earned is: " + profitTotal);
            }
            else // Error.
                Console.WriteLine("User input is not a valid retail price. Must be a number.");
            // Keep console open to read.
            Console.Read();
        }
    }
}
