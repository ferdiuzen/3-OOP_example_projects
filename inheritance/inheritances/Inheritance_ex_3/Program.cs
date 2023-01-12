using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.FirstName = "Emre";
            s.LastName = "Duru";
            s.DateTimes = Convert.ToDateTime("01/01/1997");
            s.EducationProgram = "ERP";
            s.Avenue = "Balat";
            s.HomeNumber = 35;
            s.City = "İstanbul";
            s.Gender = "E";
            /*
              foreach(var item in s.FirstName+" "+s.LastName+s.EducationProgram+s.HomeNumber+s.Avenue+s.City+s.DateTimes)
              {
                  Console.Write(item);
              }
           */

            Console.Write(s.GetFirstName());
            Console.WriteLine(s.LastName);
            Console.WriteLine(s.DateTimes);
            Console.WriteLine(s.EducationProgram);
            Console.WriteLine(s.Avenue);
            Console.WriteLine(s.HomeNumber);
            Console.WriteLine(s.City);


            Console.ReadLine();
        }
    }
}
