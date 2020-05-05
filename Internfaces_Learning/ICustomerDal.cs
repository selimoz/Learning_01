using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internfaces_Learning
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
        
    }

    class SqlServer:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Add");
        }

        public void Update()
        {
            Console.WriteLine("SQL Update");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Delete");
        }
    }

    class OracleServer:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Add");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Update");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }
    }

    class MySQLServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySQL Add");
        }

        public void Update()
        {
            Console.WriteLine("MySQL Update");
        }

        public void Delete()
        {
            Console.WriteLine("MySQL Deleted");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
              customerDal.Add();
        }
        public void Update(ICustomerDal customerDal)
        { 
            customerDal.Update();
        }
        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete();
        }
    }
}
