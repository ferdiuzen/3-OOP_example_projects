using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessProviders
{
    internal class Customer
    {
        public int Id { get; set; }
        public string FirstName { set; get; }
        public string LastName { set; get; }

        private string kkNo; //

        public string GetkkNo()
        {
            return "**********" + kkNo.Substring(kkNo.Length - 2);
        }
        
        public void SetkkNo(string value)
        {
            kkNo = value;
        }
        
        protected string telNo { set; get; } //
        public string GettelNo()
        {
            return "****" + kkNo.Substring(kkNo.Length - 2);
        }

        public void SettelNo(string value)
        {
            kkNo = value;
        }



        public string Address { set; get; } 

    }
}
