using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoComLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Especificando o data source
            //Pode ser outras coleções
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Definindo a expressão query ou expressão de consulta:

            /*O Where é um método de extensão do Linq. Ele permite a buscar de elementos de acordo com um predicado.
             Da forma abaixo, gerei uma nova coleção contendo somente os números pares.
            Agora se eu colocar o ponto depois do predicado eu posso abrir outra função do Linq que será
            aplicada em cima do resultado que eu já tenho. Para pegar os elementos da coleção original gerando 
            uma nova coleção, temos que usar o Select. Dentro do Select eu coloco um func que recebe um elemento
            e retorna um resultado*/

            /*Usamos o var porque a biblioteca Linq utiliza a coleção genérica IEnumerable. Se eu colocasse List
             eu teria que no final da consulta converter tudo para lista com o ToList. Posso colocar IEnumerable antes
            do result que vai funcionar.*/

            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(p => p * 10);

            //As expressões acima podem usar qualquer letra

            /*Executando a consulta. Para isso tenho que executar alguma operação que force a excução da minha[
            consulta*/
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }


        }
    }
}
