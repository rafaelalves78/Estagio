using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioPropostoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> eleicoes = new Dictionary<string, int>();

            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        int votos = int.Parse(line[1]);

                        if (eleicoes.ContainsKey(name))
                        {
                            eleicoes[name] += votos;
                        }
                        else
                        {
                            eleicoes[name] = votos;
                        }
                    }
                    foreach(var item in eleicoes)
                    {
                        Console.WriteLine(item.Key + ", votos: " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
