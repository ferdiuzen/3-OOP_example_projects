using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
               Customer customer = new Customer(); 
               customer.Id = 1;
               customer.FirstName = "Burak";
               customer.LastName = "Aksak";
               customer.City = "Kadıköy";



               Student student = new Student();
               student.Id = 2;
               student.Department = "IT";
            Console.WriteLine(student.Department);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
                

            //2.veri yöntemi
            //persons  bizim tarafımızdan dizi için tanımlandı
            Person[] persons = new Person[3]
            {
                new Person{FirstName="Ali"},
                new Student{FirstName="Berke"},
                new Person{FirstName="Aylin"},
                //new Customer{City="Ankara"},
                //new Student{Department="Engineer"}
            };

            Customer[] customers = new Customer[4]
            {
                new Customer{FirstName="Ali"},
                new Customer{FirstName="Berke"},
                new Customer{FirstName="Aylin"},
                new Customer{City="Ankara"},
            };
            foreach (var customer2 in customers)
            {
                Console.WriteLine(customer2.FirstName);
                Console.WriteLine(customer2.City);
            }
            // Console.WriteLine(customer.FirstName  + "  " + customer.LastName);

            //person bizim tarafımızdan döngü değerlerini yazdırmak için tanımlandı
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
            }
            
           // Console.WriteLine(persons.FirstName);
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }



    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student:Person
    {
        public string Department { get; set;}
    }

}
