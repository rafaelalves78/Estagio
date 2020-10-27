using System;
using System.IO;
using System.Collections.Generic;

namespace ArquivosParteV
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {
                
               
                IEnumerable <string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

             

                Console.WriteLine();

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string folder in files)
                {
                    Console.WriteLine(folder);
                }

              

                Directory.CreateDirectory(path + "\\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
