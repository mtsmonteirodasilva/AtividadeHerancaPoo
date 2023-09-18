using AtividadeHerancaPoo.Classes;
using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        ContaEstudante ce = new ContaEstudante();
        ce.nConta = 1;
        ce.Agencia = "001";
        ce.Titular = "Matheus Monteiro da Silva";
        ce.Saldo = 2000;
        ce.LimiteChequeEspecial = 1000;
        ce.Cpf = "065-021-762-40";
        ce.NomeInstituicao = "Ifro";
        ce.Depositar(5000);
        ce.Sacar(9000);

        ContaEmpresarial cem = new ContaEmpresarial();
        cem.nConta = 2;
        cem.Agencia = "002";
        cem.Titular = "Josemar Victor Pereira da Silva";
        cem.Saldo = 2000;
        cem.Depositar(5000);
        cem.Anuidade = 3000;
        cem.LimiteEmprestimo = 1000;
        cem.TotalEmprestimo = 1000;
        cem.FazerEmprestimo(1500);
        cem.Sacar(500);
        
        Conta conta = new Conta();
        conta.nConta = 3;
        conta.Agencia = "003";
        conta.Titular = "Elias";
        conta.Saldo = 8000;
    }
}











