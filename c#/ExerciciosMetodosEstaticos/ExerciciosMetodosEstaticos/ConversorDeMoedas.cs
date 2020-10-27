using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosMetodosEstaticos
{
    class ConversorDeMoedas
    {
        public static double Iof = 6.0;

        public static double Conversao(double cotacao, double quantidade)
        {
            double total = cotacao * quantidade;
            return total + total * Iof / 100.00;
        }
    }
}
