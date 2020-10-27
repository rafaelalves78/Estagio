using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosFixacaoPOO
{
    class Retangulo
    {
        
        public double Largura;
        public double Altura;

        public double Area()
        {
            return this.Largura * Altura;
        }

        public double Perimetro()
        {
            return (2 * (this.Largura + this.Altura));
        }

        public double Diagonal ()
        {
            return Math.Sqrt((Math.Pow(this.Largura, 2)) + (Math.Pow(this.Altura, 2)));
        }
    }
}
