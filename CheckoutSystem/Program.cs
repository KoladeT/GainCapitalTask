using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number of Apples to sell, each Apple costs 60p : ");
                int numberOfApples = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Enter number of Oranges to sell, each Orange costs 25p : ");
                int numberOfOranges = Convert.ToInt16(Console.ReadLine());
                

                double totalCost = TotalCost(numberOfApples, numberOfOranges);

                const string totalCostString = "Total cost of apples and oranges = £";
                
                Console.WriteLine(totalCostString + totalCost);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("User entries must be numbers like 1,2,3...: " + ex.Message);
                Console.WriteLine();
            }
           
        }

        public static double TotalCost(int numberOfApples, int numberOfOranges)
        {
            const double appleCost = 0.6;
            const double OrangeCost = 0.25;
            double totalCost = 0.0;

            Console.WriteLine();

            if (numberOfApples > 0 && numberOfOranges > 0)
            {
                totalCost = (numberOfApples * appleCost) + (numberOfOranges * OrangeCost);
            }
            else
            {
                Console.WriteLine("User entries cannot be negatives, please enter number that is greater than 0");
            }
            return totalCost;
        }
    }
}
