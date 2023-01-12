using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Zeynep",
                LastName = "Bostan",
                Address = "Üsküdar"
            };

            PersonManager  manager= new PersonManager();
            manager.Add(customer);


            Console.ReadKey();



        }


        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName{get;set;}

        }

        class Customer:IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
              

        }

        class Student:IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Deparment { get; set; }


        }


        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }

    }
}
