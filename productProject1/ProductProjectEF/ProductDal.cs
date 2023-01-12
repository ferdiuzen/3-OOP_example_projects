using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProjectEF
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
             using(ProductsContext context = new ProductsContext())
            {
                return context.Products.ToList();
            }
        }



    }
}
