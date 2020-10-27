namespace TipoReferenciaTipoValor
{
    //Funciona como a classe porém ele não cria uma referência, mas sim atribui um valor
    struct Point
    {
        public double x;
        public double y;

        public override string ToString()
        {
            return "( " + x + ", " + y + " ).";
        }
    }
}
