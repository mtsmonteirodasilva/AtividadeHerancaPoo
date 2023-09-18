using System.Xml;

namespace AtividadeHerancaPoo.Classes
{
    internal class ContaEstudante:Conta
    {
        public double LimiteChequeEspecial { get; set; }
        public string Cpf { get; set; }
        public string NomeInstituicao { get; set; }

        public ContaEstudante()
        {

        }
        public ContaEstudante(double LimiteChequeEspecial, string Cpf, string NomeInstituicao, int nConta, string Agencia, string Titular, double Saldo)
            :base(nConta,Agencia, Titular, Saldo) 
        { 
            this.LimiteChequeEspecial = LimiteChequeEspecial;
            this.Cpf = Cpf;
            this.NomeInstituicao = NomeInstituicao;
        }
        
        public override void Sacar(double valorSaque)
        {
            
            double saque2 = (resultado + LimiteChequeEspecial) - valorSaque;
            Console.WriteLine($"O valor do saque foi de {valorSaque}");
            Console.WriteLine($"Seu saldo atual é de {saque2} \n");
        }
    }
}
