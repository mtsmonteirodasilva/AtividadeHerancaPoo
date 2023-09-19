using AtividadeHerancaPoo.Classes;
using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        int Nconta = 002;
        string agencia = "JIPA  ";

        while (true)
        {
            Console.WriteLine("Digite \n " + "1 Para conta normal, \n " + "2 Para conta estudamte \n " + "3 Para conta espresarial \n " + "4 Para sair");
            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular: ");
            string nomeTitular = Console.ReadLine();

            if (opcao == 1)
            {
                Conta c = new Conta(Nconta, agencia, nomeTitular, 0);
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if(opcao == 1)
                    {
                        Console.WriteLine("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Depositar(valor);
                        Console.WriteLine($"Novo saldo {c.Saldo}");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Sacar(valor);
                        Console.WriteLine($"Novo saldo {c.Saldo}");
                    }
                    else if (opcao == 3)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            
            else if (opcao == 2)
            {
                Console.WriteLine("Digite o CPF do estudante");
                string cpf = Console.ReadLine();

                Console.WriteLine("Informe a instituicao");
                string instituicao = Console.ReadLine();

                ContaEstudante ce = new ContaEstudante(cpf,instituicao,Nconta, agencia, nomeTitular, 0);

                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Depositar(valor);
                        Console.WriteLine($"Novo saldo {ce.Saldo}");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Sacar(valor);
                        Console.WriteLine($"Novo saldo {ce.Saldo}");
                    }
                    else if (opcao == 3)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if (opcao == 3)
            {
                ContaEmpresarial cempresarial = new ContaEmpresarial(1000, 2000, 1000, Nconta, agencia, nomeTitular, 0);
                Nconta += 1;

                while(true) 
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para fazer empretimo e 4 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cempresarial.Depositar(valor);
                        Console.WriteLine($"Novo saldo {cempresarial.Saldo}");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cempresarial.Sacar(valor);
                        Console.WriteLine($"Novo saldo {cempresarial.Saldo}");
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("Digite o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cempresarial.FazerEmprestimo(valor);
                        Console.WriteLine($"Novo saldo {cempresarial.Saldo}");
                    }
                    else if (opcao == 4)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if(opcao == 4) 
            {
                break;            
            }
        }        
    }
}











