using System;
using System.Collections.Generic;

namespace ProductManagement
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    
    class Program
    {
        static List<Product> products = new List<Product>();
        static int nextId = 1;
        
        static void Main(string[] args)
        {
            bool exit = false;
            
            while (!exit)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Salir");
                
                string option = Console.ReadLine();
                
                switch (option)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        RemoveProduct();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
        
        static void AddProduct()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string name = Console.ReadLine();
            
            Console.Write("Ingrese el precio: ");
            decimal price = decimal.Parse(Console.ReadLine());
            
            Product product = new Product
            {
                Id = nextId++,
                Name = name,
                Price = price
            };
            
            products.Add(product);
            Console.WriteLine($"Producto '{name}' agregado con éxito.");
        }
        
        static void RemoveProduct()
        {
            Console.Write("Ingrese el ID del producto a eliminar: ");
            int id = int.Parse(Console.ReadLine());
            
            Product product = products.Find(p => p.Id == id);
            
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"Producto '{product.Name}' eliminado con éxito.");
            }
            else
            {
                Console.WriteLine($"No se encontró ningún producto con ID {id}.");
            }
        }
    }
}
