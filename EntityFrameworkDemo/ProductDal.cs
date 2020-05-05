using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        
        public List<Product> GetAllProducts()
        {
            VenusKuaforContext contextcon = new VenusKuaforContext();
            if ((contextcon.Database.Connection.State & ConnectionState.Open) != 0)
            {
                MessageBox.Show("bağlantı is ok");
            }
            else
            {
                MessageBox.Show("bağlantı is YOK");
            }
            ;
            using (VenusKuaforContext context = new VenusKuaforContext())
            {
                return context.Products.ToList();
            }
        }

        public void AddProduct(Product product)
        {
            using (VenusKuaforContext context = new VenusKuaforContext())
            {
                 context.Products.Add(product);
                 context.SaveChanges();
            }
        }
    }
}
