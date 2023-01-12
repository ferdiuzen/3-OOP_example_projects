using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
          
            {
                Id = 1,
                FirstName = "Efrun",
                LastName = "Evdi",
                Address = "Bakırköy"

            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Miray",
                LastName = "Durgun",
                Department = "Engineer"
            };

            
            PersonManager manager = new PersonManager();  
           // manager.Add(customer);
           // manager.Add2(customer);
          //  manager.Add3(student);

            //2.yöntem

            //manager.Add(new Customer { Id = 3, FirstName = "Şule", LastName = "Celep", Address = "Üsküdar" });
            //manager.Add3(new Student { Id = 4, FirstName = "Esma", LastName = "Arıkan", Department = "IT" });
            manager.Add2(new Customer { Id = 5, FirstName = "Fatih", LastName = "Bayram", Address = "Esenkent" });
            Console.ReadLine();

            
        }


        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }



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

            public string Department { get; set; }

        }


        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
            public void Add2(Customer customer)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.Address);
               
            }

            public void Add3(Student student)
            {
                Console.WriteLine(student.Department);
            }
        }

    }
}
