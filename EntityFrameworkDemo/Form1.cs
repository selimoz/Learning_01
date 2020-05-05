using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
           ProductDal productDal = new ProductDal();
           productDal.GetAllProducts();
        }

        public void SqlConnectionControl()
        {
            SqlConnection connection = new SqlConnection();
            if (connection.State == ConnectionState.Open)
            {
                MessageBox.Show("SQL OK");
            }
            else
            {
                MessageBox.Show("sql bağlı değil");
            }
        }

        private void btn_Add_Item_Click(object sender, EventArgs e)
        {
          
                _productDal.AddProduct(new Product
            {
                Amount = Convert.ToInt32(txb_ProductAmount.Text),
                Desc = txb_ProductDesc.Text,
                Name = txb_ProductName.Text,
                Price = Convert.ToDecimal(txb_ProductPrice.Text)
            });

            MessageBox.Show("Ürün eklendi");
        }
    }
}
