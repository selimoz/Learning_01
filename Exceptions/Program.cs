using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Find();
            }
            catch (ExceptionCreatedbyMe exception)

            {
                Console.WriteLine(exception.Message);
            }
          
        }

        private static void Find()
        {
            string[] fruits = new string[] {"apple", "banana", "melon"};
            if (!fruits.Contains("ahmet"))
            {
                throw new ExceptionCreatedbyMe("Record not found!");
            }
            else
            {
                Console.WriteLine("Record Find");
            }
        }
    }
}
