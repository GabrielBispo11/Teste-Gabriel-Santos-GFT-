namespace Operacoes
{
    public class Multiplicacao : Operacoes
    {
        public double valor {get; set;}

        public Multiplicacao(double valor)
        {
            this.valor = valor;
        }

        public double Calcular(double valor)
        {
            double Multiplicacao = (valor * valor);
            return valor;
        }
    }
}