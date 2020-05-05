using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class ConstructInjection
    {
        
    }

    class Product
    {
        public ILogger Logger { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        private ILogger _logger;
        public Product(ILogger logger)
        {
            _logger = logger;
        }
        public void AddProduct()
        {
            _logger.Log();
            Console.WriteLine("Product Added.");
        }

        private int _productId;
        private string _productName;


        public void ListProduct()
        {
            _productId = Id;
            _productName = Name;
            Console.WriteLine(_productId + " | "+ _productName);
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DBLogger :ILogger
    {
        public void Log()
        {
            Console.WriteLine("DBLogger is started.");
        }
    }

    class FilesLogger :ILogger
    {
        public void Log()
        {
            Console.WriteLine("FilesLogger is started.");
        }
    }

    class SmsLogger  :ILogger
    {
        public void Log()
        {
            Console.WriteLine("SMS is started.");
        }
    }
}
