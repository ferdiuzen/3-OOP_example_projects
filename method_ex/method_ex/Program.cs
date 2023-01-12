using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            /*  var sonuc = Add2(); //var bloğuyla sonuc değişkenini tanımladı ve metodtan gelen değeri atadık
              Console.WriteLine(sonuc);
             */

            var sonuc1 = Ekle1();
            Console.WriteLine("metodtan gelen sonuç="+sonuc1);
            Console.ReadLine();

        }


        static void Add()
        {
            Console.WriteLine("Eklendi");
        }

        static int Add2(int number1=30,int number2=40)
        {
            //return geriye değer döndürmeyi sağlar
            // var return number1+number2;
           
       

            var result = number1 + number2;
            return result;
        }

        static int Ekle1(int numara1 = 50,int numara2=40)
        {
            var sonuc = numara1 * numara2;
            return sonuc;

        }

    }
}
