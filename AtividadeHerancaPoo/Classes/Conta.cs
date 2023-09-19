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

        public void Depositar(double valor)
        { 
            Saldo += valor;
        }

        public virtual void Sacar(double valor) 
        { 
            if(Saldo >= valor)
            {
                Saldo -= valor;
            }
            else 
            {
                Console.WriteLine("Ñ é possível realizar este saque!");
            }
        }        
    }
}
