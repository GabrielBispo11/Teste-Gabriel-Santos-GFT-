namespace Renda
{
    public class Funcionario
    {
        public string nome;
        public string matricula;
        public double salario;
        public int dataAdmissao;
        public string CPF;

        public void receberAumento(double salario)
        {

        }

        public double calcularImposto(double salario){
            return salario;
        }


        public double GAnhoBrutoAnual(double salario)
        {
            return salario;
        }

        public double GanhoLiquidoMensal(double salario)
        {
            return salario;
        }

        public double GanhoLiquidoAnual(double salario)
        {
            return salario;
        }
    }
}