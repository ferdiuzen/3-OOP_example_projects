using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductProjectEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal=new ProductDal(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            
            using(ProductsContext context=new ProductsContext())
            {
                dgwProducts.DataSource = context.Products.ToList();

            }
        }
    }
}
