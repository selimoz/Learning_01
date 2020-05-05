using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager(25);
            //customerManager.CustomerList();

            Product product = new Product(new FilesLogger());
            product.AddProduct();
            product.ListProduct();

        }
    }

    //Bir tane CustomerMager Sınıfı var ve içerisinde birkaç tane işlem yapan
    //metod var.
    class CustomerManager 
    {
        public CustomerManager()
        {
            Console.WriteLine("ctor çağrıldı.");
        }

        private int _countpage;
        public CustomerManager(int countpage)
        {
            _countpage = countpage;
        }
        public void CustomerList()
        {
            Console.WriteLine("Customer Listed {0} pages.",  _countpage);
        }
        public void CustomerAdd()
        {
            Console.WriteLine("Customer Added.");
        }
    }
}
