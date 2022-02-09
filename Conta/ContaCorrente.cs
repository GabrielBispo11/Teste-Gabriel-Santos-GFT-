namespace Desafio_GABSANTOS_START_.Conta
{
    public class ContaCorrente
    {
        public double valor{ get; set; }

        public ContaCorrente(double valor)
        {
            this.valor = valor;
        }

        public double rendimento(double valor)
        {
            valor = (valor) + (valor*0.05);
            return valor;
        }
    }
}