using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosFixacaoPOO
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return this.Nota1 + this.Nota2 + this.Nota3;
        }

        public bool Aprovado()
        {
            if (this.NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double PontosRestantes()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60 - this.NotaFinal();
            }
        }
    }
}
