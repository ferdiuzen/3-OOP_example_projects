using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessProviders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Customer customer = new Customer();

            customer.Id = 1;
            customer.FirstName = "Suzan";
            customer.LastName = "Deniz";
            customer.Address = "İzmir";

            customer.SetkkNo("123456789099");
            customer.SettelNo("5554443330");

            Console.WriteLine(customer.GettelNo());
            
            Console.Write(customer.GetkkNo());

            Console.WriteLine(customer.Address);

            Console.WriteLine(customer.FirstName);

           // Console.WriteLine(customer.kkNo);


            Company company= new Company();
            company.Id = 1;
            company.FirstName = "Oracle Aş";
            company.komBoss = "Emre Duru";
            

            Console.WriteLine(company.komBoss);

            Console.ReadKey();
        }
    }
}
