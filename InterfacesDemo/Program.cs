using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

           IWork[] works = new IWork[]
           {
               new Worker(), 
               new Robot(), 
           };

           foreach (IWork work in works)
           {
               work.Work();
           }

        }
    }

    interface IWork
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }

    class Worker : IWork, IEat, IGetSalary
    {
        public void Work()
        {
            Console.WriteLine("Worker works...");
        }

        public void Eat()
        {
            Console.WriteLine("Worker eats...");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker gets salary...");
        }
    }

    class Robot:IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot is working...");
        }
    }
}
