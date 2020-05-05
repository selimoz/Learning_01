using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
         CustomerManager customerManager = new CustomerManager();
         customerManager.Logger = new SmsLogger();

         customerManager.Add();
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.log();
            Console.WriteLine("Add Customer");
        }
    }

    class SqlLog:ILogger
    {
        public void log()
        {
            Console.WriteLine("SQLLog is starting...");
        }
    }
    interface ILogger
    {
        void log();
    }

    class FileLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("FileLogger is starting...");
        }
    }

    class SmsLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("Sms log is starting...");
        }
    }
}
