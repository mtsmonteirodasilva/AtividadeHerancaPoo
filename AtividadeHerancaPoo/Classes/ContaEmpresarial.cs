namespace AtividadeHerancaPoo.Classes
{
    internal class ContaEmpresarial:Banco
    {
        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; } 

        public ContaEmpresarial() 
        {
        
        }

        public ContaEmpresarial(double Anuidade, double LimiteEmprestimo, double TotalEmprestimo, int nConta, string Agencia, string Titular, double Saldo)
            :base(nConta, Agencia, Titular, Saldo)
        { 
            this.Anuidade = Anuidade;
            this.LimiteEmprestimo = LimiteEmprestimo;
            this.TotalEmprestimo = TotalEmprestimo;
        }

        public void FazerEmprestimo(double valorEmprestimo)
        {       
            if(LimiteEmprestimo <= valorEmprestimo)
            {
                Console.WriteLine("O valor de empréstimo não pode ser concedido!");
            }
            else if(LimiteEmprestimo > valorEmprestimo)
            {
                double emprestimo = Saldo + valorEmprestimo;
                Console.WriteLine($"O empréstimo de {emprestimo} foi realizado com sucesso!");
            }
        }

        public override void Sacar(double valorSaque)
        {
            if(valorSaque <= 5000)
            {
                double saque = Saldo - valorSaque;
                Console.WriteLine($"O valor de saque foi de {saque}");
            }
            else if(valorSaque > 5000)
            {
                double saque2 = (Saldo - valorSaque - 5);
                Console.WriteLine($"O valor de saque foi de {saque2}");
            }
           
        }

    }
}
