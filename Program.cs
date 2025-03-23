using System;
using System.Linq;

namespace RestaurantBilling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los precios de los platos (separados por comas): ");
            string input = Console.ReadLine();
            
            decimal[] prices = input.Split(',')
                                  .Select(price => decimal.Parse(price.Trim()))
                                  .ToArray();
            
            decimal subtotal = prices.Sum();
            
            Console.Write("¿Desea agregar una propina personalizada? (s/n): ");
            string choice = Console.ReadLine().ToLower();
            
            decimal tipPercentage = 0.10m;
            
            if (choice == "s")
            {
                Console.Write("Ingrese el porcentaje de propina: ");
                tipPercentage = decimal.Parse(Console.ReadLine()) / 100;
            }
            
            decimal tipAmount = subtotal * tipPercentage;
            decimal total = subtotal + tipAmount;
            
            Console.WriteLine($"Total a pagar (con propina del {tipPercentage * 100}%): {total}");
        }
    }
}
