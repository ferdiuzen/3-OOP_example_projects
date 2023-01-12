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
            Database database = new OracleServerAccess();
            database.Add();

            Database database2 = new SqlServerAccess();
            database2.Delete();


            Console.ReadLine();
        }

        //Abstract classlar tamamlanmamış metotların implementinde kullanılır
        abstract class Database   //Başına Abstract yazmam yeterli
        {
            public void Add()
            {
                Console.WriteLine("Eklendi");
            }
            public abstract void Delete();    //Tamamlanmamış metod
        }

        
        class SqlServerAccess:Database
        {
            public  override void Delete() //override!
            {
                Console.WriteLine("Sql Kayıt Silindi");
            }
        }
    

        class OracleServerAccess:Database
        {
            public override void Delete()
            {
                Console.WriteLine("Oracle Kayıt Silindi");
            }
        }
    
    }
  





    
}
