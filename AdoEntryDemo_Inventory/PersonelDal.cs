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
    public class PersonelDal : Personel
    {
        SqlConnection _connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = VenusKuafor; Integrated Security = True");
        public void AddPersonel(Personel personel)
        {
            SqlConnectionControl();

            SqlCommand command = new SqlCommand("INSERT INTO Personel values(@name,@surname,@nationalityId,@birthday,@title)", _connection);

            command.Parameters.AddWithValue("@name", personel.Personel_Name);
            command.Parameters.AddWithValue("@surname", personel.Personel_Surname);
            command.Parameters.AddWithValue("@nationalityId", personel.Personel_Nationality_Id);
            command.Parameters.AddWithValue("@birthday", personel.Personel_BirthDay.Year);
            command.Parameters.AddWithValue("@title", personel.Personel_Title);

            command.ExecuteNonQuery();

            _connection.Close();

            GetAllPersonel();

            MessageBox.Show("Personel Eklendi.");

        }

        public void DeletePersonel(int id)
        {
            SqlConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Personel where Id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);
            
            command.ExecuteNonQuery();
            _connection.Close();

        }

       public void Update(Personel personel)
        {
             SqlConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update Personel set Personel_Name=@name, Personel_Surname=@surname, Personel_Nationality_Id=@nationalityid, Personel_BirthDay=@birthday, Personel_Title=@title where Id=@id", _connection);

            command.Parameters.AddWithValue("@id", personel.Id);
            command.Parameters.AddWithValue("@name", personel.Personel_Name);
            command.Parameters.AddWithValue("@surname", personel.Personel_Surname);
            command.Parameters.AddWithValue("@nationalityId", personel.Personel_Nationality_Id);
            command.Parameters.AddWithValue("@birthday", personel.Personel_BirthDay.Year);
            command.Parameters.AddWithValue("@title", personel.Personel_Title);

            command.ExecuteNonQuery();
            _connection.Close();


        }
        public DataTable GetAllPersonel()
        {

            SqlConnectionControl();
            SqlCommand command = new SqlCommand("select * from Personel", _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dtTable = new DataTable();

            dtTable.Load(dataReader);
            
            dataReader.Close();
            _connection.Close();

            return dtTable;
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
