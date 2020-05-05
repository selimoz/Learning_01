using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoEntryDemo_Inventory
{
    public partial class Form2 : Form
    {
        PrudoctDal _prudoctDal = new PrudoctDal();
        PersonelDal _personelDal = new PersonelDal();
        public Form2()
        {
            InitializeComponent();
            LoadGridview_Form2();
            LoadGridView_Personel();
            
        }

        private void LoadGridview_Form2()
        {
            dgrd_View_Form2.DataSource = _prudoctDal.GetAllProducts();
        }

        private void LoadGridView_Personel()
        {
            dgview_Personel.DataSource = _personelDal.GetAllPersonel();
        }

        private void btn_Add_Item_Click(object sender, EventArgs e)
        {
            if (txb_ProductName.Text != "")
            {
               _prudoctDal.Add(new Product
               {
                   Amount =Convert.ToInt32(txb_ProductAmount.Text),
                   Desc = txb_ProductDesc.Text,
                   Name = txb_ProductName.Text,
                   Price =Convert.ToDecimal(txb_ProductPrice.Text)
               });
               
               MessageBox.Show("Ürün eklendi...");
            }
            else
            {
                MessageBox.Show("Lütfen ürün adını yazınız!");
            }
            LoadGridview_Form2();
        }

        private void btn_Add_Personel_Click(object sender, EventArgs e)
        {
            PersonelDal personelDal = new PersonelDal();
            personelDal.AddPersonel(new Personel
            {
                Personel_BirthDay = dTime_Birthday.Value,
                Personel_Name = txb_PersonelName.Text,
                Personel_Nationality_Id = int.Parse(txb_PersonelIdentity.Text),
                Personel_Surname = txb_PersonelSurname.Text,
                Personel_Title = txb_PersonelTitle.Text
            });
            LoadGridView_Personel();

        }

        private void dgview_Personel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_PersonelName.Text = dgview_Personel.CurrentRow.Cells[1].Value.ToString();
            txb_PersonelSurname.Text = dgview_Personel.CurrentRow.Cells[2].Value.ToString();
            txb_PersonelIdentity.Text = dgview_Personel.CurrentRow.Cells[3].Value.ToString();
            txb_PersonelTitle.Text = dgview_Personel.CurrentRow.Cells[5].Value.ToString();
            dTime_Birthday.Text = dgview_Personel.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_Update_Personel_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel
            {
                Id = Convert.ToInt32(dgview_Personel.CurrentRow.Cells[0].Value),
                Personel_Name = txb_PersonelName.Text,
                Personel_Surname = txb_PersonelSurname.Text,
                Personel_Title = txb_PersonelTitle.Text,
                Personel_BirthDay = dTime_Birthday.Value,
                Personel_Nationality_Id =Convert.ToInt32(txb_PersonelIdentity.Text)
            };

            _personelDal.Update(personel);

            MessageBox.Show("updated personel");

            LoadGridView_Personel();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgview_Personel.CurrentRow.Cells[0].Value);
            _personelDal.DeletePersonel(id);
            LoadGridView_Personel();
            MessageBox.Show("Kayıt Silindi!");

        }
    }
}
