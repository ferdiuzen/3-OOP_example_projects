using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductProject
{
    public class ProductDal {

        //   List<Product> products; Data Listelemek için kullanılır

        // SqlConnection yeni bağlantı yapmamızı sağlar   SqlConnection connection=new SqlConnection
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Products;integrated security=true");//integrated security yerel bağlantı için true yapılır eğer uzaktan veri tabanı bağlantısı sağlanacaksa false yapılıp kullanıcı adı ve password bilgileri girilmeli!
        //Sql bağlantısını bu klastaki her bölümde kulllanmak için dışarı çektik
        //connection'ı tüm klaslarda kullanmak için başına (_!!!!) yazdık! _connection oldu
        public List<Product> GetAll()
        {
            // Veri tabanı bağlantısı için temel referans:   SqlConnection connection = new SqlConnection("server=(localdb)\\MSSQLLocalDB");  // initial katalog veri tabanı isminin yazıldığı bölüm


            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);//Veri tabanındaki dataları listeler

            SqlDataReader reader = command.ExecuteReader(); //Sql den gelen datayı okur

            List<Product> products = new List<Product>(); // Okunan datayı product listine atar

            while (reader.Read()) //satır sonuna kadar okumak için tanımlandı
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])

                };

                products.Add(product);
            }
            reader.Close();
            _connection.Close();


            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)// Her sayfa girildiğinde veri tabanı açılmaması için- açık olma durumu var!- kontrol yapılır. Eğer zaten veritabanı bağlantısı varsa tekrar açılmaz. Bağlantı yoksa bağlantıyı sağlar. Connection state iki duruma sahiptir open - closed
            {
                _connection.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand(
               "insert into Products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();





        }

        public void Update(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand(
               "Update Products set Name=@name,UnitPrice=@unitPrice,StockAmount=@stockAmount where Id=@id", _connection);  //@name parametresini veritabanındaki Name alanına atar -- Idlerin eşit olduğ
            command.Parameters.AddWithValue("@name", product.Name);//Textten gelen name değerini @name parametresine atar
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }


        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand(
               "Delete from Products where Id=@id", _connection);  //@name parametresini veritabanındaki Name alanına atar -- Idlerin eşit olduğ
            
            command.Parameters.AddWithValue("@id",id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
