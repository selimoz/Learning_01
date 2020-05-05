using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
          //  ArrayList();

          List<Tree> trees = new List<Tree>
          {
            new Tree(){Id = 3,Name = "Defne"},
            new Tree(){Id = 4, Name = "Kayısı"}
          };

          trees.Add(new Tree(){Id=1,Name = "Çam"});
          trees.Add(new Tree(){Id=2,Name = "Kavak"});

          foreach (var tree in trees)
          {
              Console.WriteLine(tree.Name +"|"+ tree.Id);
          }

         var count =  trees.Count();
         Console.WriteLine(count);

        }

        private static void ArrayList()
        {
            ArrayList Fruits = new ArrayList();
            Fruits.Add("Apple");
            Fruits.Add("Banana");
            Fruits.Add("Melon");
            Fruits.Add(1044);
            Fruits.Add(';');
            foreach (var fruit in Fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }

    class Tree
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
