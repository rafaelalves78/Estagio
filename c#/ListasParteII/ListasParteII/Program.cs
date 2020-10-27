using System;
using System.Collections.Generic;

namespace ListasParteII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> ();

           

            list.Add("Maria");
            list.Add("Alex");
            list.Add("João");
            list.Add("Bob");
            list.Add("Ana");

            
            list.Insert(2, "Marco");

            foreach(string pessoa in list)
            {
                Console.WriteLine(pessoa);
            }

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("List cout: " + list.Count);

            Console.WriteLine("-----------------------------------------------");

            
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s1);

            Console.WriteLine("-------------------------------------------------");

           
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            Console.WriteLine("-------------------------------------------------");

            
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos1);

            Console.WriteLine("-------------------------------------------------");

           
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos2);

            Console.WriteLine("-------------------------------------------------");

            
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
                Console.WriteLine("-------------------------------------------");
            }

          
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------------");

            
            list.RemoveAll(x => x[0] == 'M');
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------------");

            list.RemoveAt(2);
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("-------------------------------------------");

            list.Add("Karol");
            list.Add("Alexandra");
            list.Add("Telma");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------------------");

            
            list.RemoveRange(2, 2);
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
