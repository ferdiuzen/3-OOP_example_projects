using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerAccess());
            customerManager.Update(new OracleServerCustomerAccess());
            Console.ReadLine();
        }
    }
}
