using System;
using System.Collections.Generic;

namespace EstruturaDictionaRySortEdDictionaRy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

          
            cookies["user"] = "rafael";
            cookies["email"] = "rafaelalves78@gmail.com";
            cookies["phone"] = "970707070";

           
            cookies["phone"] = "837337388";

           
            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

        
            cookies.Remove("email");

          
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There's no e-mail key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES: ");
           
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item);
            }
        }
    }
}
