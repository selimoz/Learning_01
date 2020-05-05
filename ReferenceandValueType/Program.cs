using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceandValueType
{
    class Program
    {
        static void Main(string[] args)
        {

            int sel = 2;
            int dil = 3;
            
            dil = sel;
            sel = 5;

            Console.WriteLine(dil);
            Console.WriteLine(dil);

            DataTable dataTable = new DataTable();
            DataTable dataTable2= new DataTable();

            dataTable2 = dataTable;

        }
    }
}
