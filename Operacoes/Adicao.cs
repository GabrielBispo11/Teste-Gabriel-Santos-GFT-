namespace Operacoes
{
    public class Adicao : Operacoes
    {
        public double valor {get; set;}

        public Adicao(double valor)
        {
            this.valor = valor;
        }

        public double Calcular(double valor)
        {
            double Operacoes = (valor + valor);
            return valor;
        }
    }
}