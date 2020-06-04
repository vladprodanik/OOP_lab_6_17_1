using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOP_lab_6_17_1
{
    class Program : Work
    {
        public void SaleM()
        {
            List<Sale> sale = new List<Sale>();
            List<Price> price = new List<Price>();

            Console.Write("Кiлькiсть записiв: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                Console.Write("Назва: ");
                string s1 = Console.ReadLine();

                Console.Write("Вартiсть: ");
                string s2 = Console.ReadLine();

                Console.Write("Дата: ");
                string s3 = Console.ReadLine();

                Console.Write("Кiлькiсть: ");
                string s4 = Console.ReadLine();

                price.Add(new Price(s1, int.Parse(s2)));

                sale.Add(new Sale(DateTime.Parse(s3), s1, int.Parse(s4)));
            }

            double[] temprPrice = new double[sale.Count];

            var sortedPrice = price.OrderBy(o => o.ItemPrice).ToList();

            List<Sale> newSale = new List<Sale>();

            List<double> newPrice = new List<double>();

            foreach (Sale s in sale)
            {
                newPrice.Add(Find(s, price).ItemPrice * s.Count);

                newSale.Add(s);
            }

            int cnt = newSale.Count;

            sale = new List<Sale>();

            for (int i = 0; i < cnt; i++)
            {
                int index = newPrice.IndexOf(newPrice.Max());

                sale.Add(newSale[index]);

                newPrice.RemoveAt(index);
                newSale.RemoveAt(index);
            }

            sale.Reverse();


            double totalPrice = 0, totalTempPrice = 1;

            Console.WriteLine("\n{0,-15} {1, -10} {2, -10} {3, -15}", "Назва", "Дата", "Кiлькiсть", "Цiна");

            double tempPrice;
            
            foreach (Sale s in sale)
            {
                for (int i = 0; i < price.Count; i++)
                {
                    if (s.Name == price[i].Name)
                    {
                        tempPrice = price[i].ItemPrice * s.Count;

                        Console.WriteLine("{0,-15} {1, -10} {2, -10} {3, -15}", s.Name, s.Date.ToShortDateString(), s.Count, tempPrice);
                    }
                }
            }

            foreach (Sale s in sale)
            {
                totalTempPrice = 0;

                for (int i = 0; i < sortedPrice.Count; i++)
                {
                    if (s.Name == sortedPrice[i].Name)
                    {
                        tempPrice = sortedPrice[i].ItemPrice;
                        totalTempPrice = tempPrice * s.Count;
                    }
                }

                totalPrice += totalTempPrice;
            }

            Console.WriteLine("\nВартість виготовленої продукції: {0}", totalPrice);

        }

        static void Main(string[] args)
        {
            new Program().SaleM();
        }

        public Price Find(Sale Item, List<Price> Items)
        {
            foreach (Price s in Items)
            {
                if (Item.Name == s.Name)
                {
                    return s;
                }
            }
            
            return null;
        }
    }
}
