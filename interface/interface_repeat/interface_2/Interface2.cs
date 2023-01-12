using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2
{
    internal interface ICustomerAccess
    {
        void Add();
        void Update();
        void Delete();



    }

    class SqlServerCustomerAccess:ICustomerAccess
    {
        public void Add()
        {
            Console.WriteLine("Sql Kayıt Eklendi");

        }

        public void Update()
        {
            Console.WriteLine("Sql Kayıt Güncellendi");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Kayıt Silindi");
        }
    }

    class OracleServerCustomerAccess:ICustomerAccess
    {
        public void Add()
        {
            Console.WriteLine("Oracle Kayıt Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Kayıt Güncellendi");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Kayıt Silindi");
        }

    }

    class CustomerManager
    {
        public void Add(ICustomerAccess customeraccess)
        {
            customeraccess.Add();
          
        }

        public void Update(ICustomerAccess customeraccess)
        {
            customeraccess.Update();

        }

        public void Delete(ICustomerAccess customeraccess)
        {
            customeraccess.Delete();

        }
    }



}
