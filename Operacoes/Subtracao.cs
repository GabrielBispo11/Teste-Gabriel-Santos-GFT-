namespace Operacoes
{
    public class Subtracao : Operacoes
    {
        public double valor {get; set;}

        public Subtracao(double valor)
        {
            this.valor = valor;
        }

        public double Calcular(double valor)
        {
            double Subtracao = (valor - valor);
            return valor;
        }
    }
}