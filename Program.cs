using System;
using System.Collections.Generic;
using System.Globalization;
using Tag.Entities;

namespace Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>(){};

            Console.Write("Enter the number of Products: ");
            int numberProducts = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberProducts; i++)
            {
                Console.WriteLine($"Product #{i} data");
                Console.Write("Common, Used or Imported(c/u/i)?");
                char typeProduct = char.Parse(Console.ReadLine());

                if (typeProduct == char.Parse("c")){

                    Console.Write("Name: ");
                    string nameProduct = Console.ReadLine();

                    Console.Write("Price: ");
                    double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new Product(nameProduct, priceProduct));

                } else if(typeProduct == char.Parse("u")){

                    Console.Write("Name: ");
                    string nameProduct = Console.ReadLine();

                    Console.Write("Price: ");
                    double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(nameProduct, priceProduct, manufacture));

                } else if(typeProduct == char.Parse("i")){

                    Console.Write("Name: ");
                    string nameProduct = Console.ReadLine();

                    Console.Write("Price: ");
                    double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Costoms Fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(nameProduct, priceProduct, fee));
                
                } else{
                    Console.WriteLine("Ivalied Option");
                    i--;
                }
            }

            System.Console.WriteLine("");
            Console.WriteLine("PRICE TAGS:");
            foreach(Product item in products)
            {
                Console.WriteLine(item.priceTag());
            }


        }
    }
}
