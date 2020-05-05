using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoEntryDemo_Inventory
{
   public class Personel
    {
        public int Id { get; set; }
        public string Personel_Name { get; set; }
        public string Personel_Surname { get; set; }
        public int Personel_Nationality_Id { get; set; }
        public DateTime Personel_BirthDay { get; set; }
        public string Personel_Title { get; set; }
    }
}
