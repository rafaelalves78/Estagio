using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //SEM O @ SERIA NECESSARIO COLOCAR O CAMINHO ASSIM: C:\\PROJETOS\\FILE.TXT
            string sourcePath = @"c:\projetos\file1.txt";
            string targetPath = @"c:\projetos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                //A função copyTo copia o arquivo para um caminho de destino
                fileInfo.CopyTo(targetPath);

                //ReadAllLines lê todas as linhas do arquivo e irá colocar no vetor
                //Como a classe file nao instancia objetos, tem que ser colocado como parametro o arquivo a ser lido
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
