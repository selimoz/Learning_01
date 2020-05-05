using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdoEntryDemo_Inventory
{
    public class PrudoctDal
    {
        SqlConnection _connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = VenusKuafor; Integrated Security = True");

        //string _connectionstring = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = VenusKuafor; Integrated Security = True";
       // SqlConnection connection = new SqlConnection(_connectionstring);
        public DataTable GetAllProducts()
        {
                SqlConnectionControl();
                SqlCommand command = new SqlCommand("Select * From Items", _connection);
                
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();

                dataTable.Load(reader);
                reader.Close();
          
          
            _connection.Close();

            return dataTable;
        }

       

        public void Add(Product product)
        {
            SqlConnectionControl();

            SqlCommand command= new SqlCommand("Insert into ITEMS values(@Name,@Description,@Price,@Amount)",_connection);

            command.Parameters.AddWithValue("@Name",product.Name);
            command.Parameters.AddWithValue("@Description", product.Desc);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@Amount", product.Amount);
            

            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void _sqlConnectionControl()
        {
            SqlConnectionControl();
        }
        private void SqlConnectionControl()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
                
            }
            else
            {
                MessageBox.Show("Sql bağlantısı YOK");
            }
        }
    }
}
