namespace Operacoes
{
    public class Divisao : Operacoes
    {
        public double valor {get; set;}

        public Divisao(double valor)
        {
            this.valor = valor;
        }

        public double Calcular(double valor)
        {
            double Divisao = (valor / valor);
            return valor;
        }
    }
}