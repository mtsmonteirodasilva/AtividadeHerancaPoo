namespace AtividadeHerancaPoo.Classes
{
    internal class ContaEmpresarial:Conta
    {
        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; } 

    
        public ContaEmpresarial(double Anuidade, double LimiteEmprestimo, double TotalEmprestimo, int nConta, string Agencia, string Titular, double Saldo)
            :base(nConta, Agencia, Titular, Saldo)
        { 
            this.Anuidade = Anuidade;
            this.LimiteEmprestimo = LimiteEmprestimo;
            this.TotalEmprestimo = TotalEmprestimo;
        }

      

        public override void Sacar(double valor)
        {
            if(valor <= Saldo) 
            {
                Saldo -= valor;
                if (valor >= 5000)
                {
                    Saldo -= 5;
                }
            }
           else
            {
                Console.WriteLine("Saldo insuficiente! ");
            }
           
        }
        public void FazerEmprestimo(double valor)
        {
           if(valor <= LimiteEmprestimo - TotalEmprestimo)
           {
                Saldo += valor;
                TotalEmprestimo += valor;
                Console.WriteLine($"Emprestimo realizado com sucesso");
            }
           else 
           {
                Console.WriteLine("Valor indisponivível! ");
           }
        }

    }
}
