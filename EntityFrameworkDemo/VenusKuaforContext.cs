using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public class VenusKuaforContext  : DbContext
    {
        public VenusKuaforContext() : base("VenusKuaforContext")
        {
            MessageBox.Show("Test");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Personel>  Personels { get; set; }
        
    }
}
