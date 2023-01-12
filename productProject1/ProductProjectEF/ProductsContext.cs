using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProjectEF
{
    public class ProductsContext:DbContext   // EF Context i olabilmesi için DbContext inherit edilir //Bu bölüm veritabanı ismi + Context
    {
        public DbSet<Product> Products { get; set; } //Bu bölüm veri tabanımızdaki tablo ismi ile aynı olmalı (products)

    }
}
