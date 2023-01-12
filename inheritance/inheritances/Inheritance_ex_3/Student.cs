using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_ex_3
{
    internal class Student : Base
    {
        public string EducationProgram { get; set; }//Eğitim Bölümü

        public string GetFirstName()
        {
            if (Gender == "E")
            {
                return $"Mr  {FirstName}";
            }
            else
            {
                return $"Mrs  {FirstName}";

            }
          
        }

       // public string LastName { get => LastName; set => LastName = value.ToUpper(); }


    }
}
