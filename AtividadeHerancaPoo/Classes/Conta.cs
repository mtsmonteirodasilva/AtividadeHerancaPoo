namespace AtividadeHerancaPoo.Classes
{
    internal class Conta
    {
        public int nConta { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        
        public Conta()
        { 
        
        }

        public Conta(int nConta, string Agencia, string Titular, double Saldo) 
        {
            this.nConta = nConta;
            this.Agencia = Agencia;
            this.Titular = Titular;
            this.Saldo = Saldo;
        }

         public double resultado = 0;
        public void Depositar(double valor)
        { 
            resultado = Saldo + valor;
            Console.WriteLine($"Deposito de {valor} realizado!");
            Console.WriteLine($"Seu saldo atual é de {resultado}");
        }

        public virtual void Sacar(double valorSaque) 
        { 
            if(Saldo >= valorSaque)
            {
                double saque = Saldo - valorSaque;
                Console.WriteLine($"O valor de saque foi de {saque}");
            }
            else if(Saldo < valorSaque)
            {
                Console.WriteLine("Ñ é possível realizar este saque!");
            }
        }        
    }
}
