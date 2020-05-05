using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Internfaces_Learning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // StudentAdd();
            //InterFaceDemo2();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                 new SqlServer(), 
                 new OracleServer(),
                 new MySQLServer(), 
            };

            foreach (ICustomerDal customerDal in customerDals)
            {
                customerDal.Add();
            }

        }

        private static void InterFaceDemo2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServer());
            Console.WriteLine("------------------------");
            customerManager.Delete(new OracleServer());
            Console.WriteLine("------------------------");
            customerManager.Delete(new SqlServer());
        }

        private static void AddStudents()
        {
            StudentAdd();
        }

        private static void StudentAdd()
        {
            List<Student> students = new List<Student>
            {
                new Student() {Id = 1, Name = "Dilek", Surname = "YAVUZER"},
                new Student() {Id = 2, Name = "Doruk", Surname = "ÖZKAYA"},
                new Student() {Id = 3, Name = "Seda", Surname = "ÖZKAYA"},
                new Student() {Id = 4, Name = "Selim", Surname = "ÖZKAYA"}
            };
            Console.WriteLine();
            foreach (var student in students)
            {
                Console.WriteLine("Okul No:{0}, İsim:{1}, Soyisim:{2}", student.Id, student.Name, student.Surname);
                Console.WriteLine("------------------------------");
            }
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
    }

    public class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
    }

    public class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    
}
