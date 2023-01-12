using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); //Referans oluşturuldu
            customerManager.Add(); // class içindeki Add metodu çağrıldı ve içindeki işlem çalıştırıldı
            customerManager.Update(); //class içindeki Update """" """""" ve """""

            // ilk kayıt giriş set bloğundan prop kullanılarak yapılır
            Customer customer=new Customer();
            customer.ID = 1;
            customer.FirstName = "Emre";
            customer.LastName = "Duru";
            customer.City = "İstanbul";

            Console.WriteLine(customer.FirstName);
            //2. kayıt giriş get bloğundan alınır
            Customer customer2 = new Customer
            {
                ID=2, FirstName="Sefa",LastName="Kağıt",City="Of"
            };

            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);          /*  ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            */
          // 2.işlem dışarıdan class oluşturuldu ve referans çağrıldı
            ProductManager productManager = new ProductManager();
            {
                productManager.Add();
                productManager.Update();
            }

            Console.ReadLine();
        }
        //1.işlem
        class CustomerManager  //CustomerManager isimli class oluşturduk
        {
            public void Add() //1.Method
            {
                Console.WriteLine("Müşteri Eklendi");
            }

            public void Update() //2.Method
            {
                Console.WriteLine("Müşteri kaydı güncellendi");
            }


        }

       /* class ProductManager
        {
            public void Add()
            {
                Console.WriteLine("ürün eklendi");
            }

            public void Update()
            {
                Console.WriteLine("ürün kaydı güncellendi");
            }




        }
       */
    }
}
