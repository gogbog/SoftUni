using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();

            int productsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < productsCount; i++)
            {
                string[] productInfo = Console.ReadLine().Split('-');
                string productName = productInfo[0];
                decimal productPrice = decimal.Parse(productInfo[1]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, 0);
                }

                products[productName] = productPrice;
            }

            List<Customer> customers = new List<Customer>();

            while (true)
            {
                //Toshko-Bira,3
                string[] customerInfo = Console.ReadLine().Split('-', ',');

                if (customerInfo[0].Equals("end of clients"))
                {
                    break;
                }

                string customerName = customerInfo[0];
                string orderedProductName = customerInfo[1];
                int orderedProductQuantity = int.Parse(customerInfo[2]);

                if (!products.ContainsKey(orderedProductName))
                {
                    continue;
                }

                if (customers.Any(c => c.name == customerName))
                {
                    Customer customer = customers.First(c => c.name == customerName);

                    if (!customer.OrderedProductsQuantities.ContainsKey(orderedProductName))
                    {
                        customer.OrderedProductsQuantities.Add(orderedProductName, 0);
                    }

                    customer.OrderedProductsQuantities[orderedProductName] += orderedProductQuantity;
                    customer.Bill += orderedProductQuantity * products[orderedProductName];
                }
                else
                {
                    Customer customer = new Customer();
                    customer.name = customerName;
                    customer.OrderedProductsQuantities = new Dictionary<string, int>();
                    customer.OrderedProductsQuantities.Add(orderedProductName, orderedProductQuantity);
                    customer.Bill += orderedProductQuantity * products[orderedProductName];

                    customers.Add(customer);
                }

            }

            foreach (Customer customer in customers.OrderBy(x => x.name))
            {
                Console.WriteLine(customer.name);

                foreach (var productInfo in customer.OrderedProductsQuantities)
                {
                    Console.WriteLine("-- {0} - {1}", productInfo.Key, productInfo.Value);
                }

                Console.WriteLine("Bill: {0:F2}", customer.Bill);
            }
            Console.WriteLine("Total bill: {0:F2}", customers.Sum(x => x.Bill));
        }
    }

    class Customer
    {
        public string name { get; set; }

        public Dictionary<string, int> OrderedProductsQuantities { get; set; }

        public decimal Bill { get; set; }
    }
}
