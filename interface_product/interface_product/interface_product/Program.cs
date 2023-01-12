using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_product
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            ProductManager manager=new ProductManager();
            manager.Add(new Customer { ID=1,Name="Ahmet",LastName="Turan",Address="Ankara",OrderNumber=1000});
            manager.Add2(new Customer { ID = 2, Name = "Lale", LastName = "Gümüşkaya", Address = "İstanbul" });

            manager.Add(new Customer());
            manager.Add(new Product { ID = 3, Name = "Macbook", Price = 40000, Stock = 100, OrderNumber = 5645 });

            manager.ProductAdd(new Product());

            ProductManager seller = new ProductManager();
            seller.SellerAdd(new Seller { ID = 1, Name = "fatih", LastName = "bayram", OrderNumber = 559966 });
            Console.ReadLine();

        }

        interface ICustomer
        {
            int ID { get; set; }
            string Name { get; set; }

            int OrderNumber { get; set; }
        }


        class Customer:ICustomer
        {
            public string LastName { get; set; }
            public string Address { get; set; }
            public int ID { get; set; }
            public string Name { get; set; }
            public int OrderNumber { get; set; }
           
            public void Add2()
            {
                Console.WriteLine("Customer Eklendi");
            }

            
        }

        class Seller:ICustomer
        {
            public string LastName { get; set; }
            public string CompanyName  { get; set; }
            public int ID { get; set; }
            public string Name { get; set; }
            public int OrderNumber { get; set; }
        }


        class Product:ICustomer
        {
            public int Stock { get; set; }
            public int Price { get; set; }
            public int ID { get; set; }
            public string Name { get; set; }
            public int OrderNumber { get; set; }

            public void productAdd()
            {
                Console.WriteLine("Ürün Eklendi");

            }

        }


        class ProductManager
        {
            public void Add(ICustomer customer)
            {
                
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.ID);
                Console.WriteLine(customer.OrderNumber);
                
            }

          
            public void Add2(Customer customer1)
            {
                
                Console.WriteLine(customer1.LastName);
                Console.WriteLine(customer1.Address);
                customer1.Add2();
            }

            public void ProductAdd(Product product)
            {
                Console.WriteLine(product.ID);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.OrderNumber);
                Console.WriteLine(product.Stock);
                product.productAdd();
            }

            public void SellerAdd(Seller seller)
            {
                Console.WriteLine(seller.Name);
                Console.WriteLine(seller.LastName);
                Console.WriteLine(seller.ID);
                Console.WriteLine(seller.OrderNumber);
            }

        }



    }
}
