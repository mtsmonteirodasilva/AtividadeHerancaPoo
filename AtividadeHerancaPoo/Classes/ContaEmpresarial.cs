namespace AtividadeHerancaPoo.Classes
{
    internal class ContaEmpresarial:Banco
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

        public double void FazerEmprestimo(double valor)
        {
            
            if(Saldo <= 0)
            {
                Console.WriteLine("O valor de empréstimo não pode ser concedido!");
            }
            else if(Saldo > 0) 
            {
                double esprestimo = Saldo + valor;
                Console.WriteLine("O empréstimo foi realizado com sucesso!");
            }
        }
        public override void Sacar(double valorSaque)
        {
            if(valorSaque <= 5000)
            {
                double saque = Saldo - valorSaque;
                Console.WriteLine($"O valor de saque foi de {saque}");
            }
            else
            {
                Console.WriteLine("Ñ é possivel realizar saque, voce já atingiu o limite de hoje.");
            }
           
        }

    }
}
