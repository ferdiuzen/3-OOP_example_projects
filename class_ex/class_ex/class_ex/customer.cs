using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ex
{
    internal class Customer
    {  // ilk önce property tanımlaması yapıyoruz

        private string _firstName;
        private string _lastName;
        //Kapsülleme  Encapsulation işlemi
        public string FirstName
        {
            get
            {
                return "Bay" + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public int ID { get; set; }
        //public string FirstName { get; set; }  

        // public string LastName { get; set; }
        public string City { get; set; }


        public string LastName
        {
            get
            {
                return "soyadınız  " + _lastName;
            }
            set { _lastName = value; }
        }
    }
}
