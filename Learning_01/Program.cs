using System;
using System.Linq;

namespace Learning_01
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Selim.Test();
            string result;
            result = Selim.Test();
            Console.WriteLine(Selim.Multply(2, 3, 4, 5, 6, 3, 45, 4545, 55));
            
        }
       
    }

    public class Selim
    {
        public static string Test()
        {
            string resulttext = "resulttext döndü";
            Console.WriteLine(resulttext);
            return resulttext;
        }

        public static int Multply(params int[] numberInts)
        {
            return numberInts.Sum();
        }
    }
}
