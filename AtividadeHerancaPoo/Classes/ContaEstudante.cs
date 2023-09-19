using System.Xml;

namespace AtividadeHerancaPoo.Classes
{
    internal class ContaEstudante:Conta
    {
        public double LimiteChequeEspecial { get; set; }
        public string Cpf { get; set; }
        public string NomeInstituicao { get; set; }

       
        public ContaEstudante( string Cpf, string NomeInstituicao, int nConta, string Agencia, string Titular, double Saldo)
            :base(nConta,Agencia, Titular, Saldo) 
        { 
            this.LimiteChequeEspecial = LimiteChequeEspecial;
            this.Cpf = Cpf;
            this.NomeInstituicao = NomeInstituicao;
        }
        
        public override void Sacar(double valor)
        {
            if(valor <= Saldo +LimiteChequeEspecial)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}
