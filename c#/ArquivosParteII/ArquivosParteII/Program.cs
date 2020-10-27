using System;
using System.IO;

namespace ArquivosParteII
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\projetos\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                
                sr = File.OpenText(path);

                

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An Error acurred: " + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();

            }
        }
    }
}
