using System;

namespace TipoReferenciaTipoValor
{
    class Program
    {
        static void Main(string[] args)
        {
            //não preciso instanciar um objeto porque é tipo struc ou tipo valor. A declaração dele já cria as caixinhas no
            //steck da memória e posso utilizá-las normalmente.
            Point p;
            p.x = 10;
            p.y = 20;

            Console.WriteLine(p);

            //Mas ele tambem aceita o comando new

            p = new Point();

            Console.WriteLine(p);

            //mesmo sendo tipo struct, eu tenho que inicializar
        }
    }
}
