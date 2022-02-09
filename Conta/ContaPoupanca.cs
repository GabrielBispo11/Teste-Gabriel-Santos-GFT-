namespace Desafio_GABSANTOS_START_.Conta
{
    public class ContaPoupanca
    {
        public double valor{ get; set; }

        public ContaPoupanca(double valor)
        {
            this.valor = valor;
        }
        public double rendimento(double valor)
        {
            valor = (valor) + (valor*0.07);
            return valor;
        }

    }
}