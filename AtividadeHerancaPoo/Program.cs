using AtividadeHerancaPoo.Classes;
using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        ContaEstudante CE = new ContaEstudante();
        CE.nConta = 1;
        CE.Agencia = "001";
        CE.Titular = "Matheus Monteiro da Silva";
        CE.Saldo = 2000;
        CE.LimiteChequeEspecial = 1000;
        CE.Cpf = "065-021-762-40";
        CE.NomeInstituicao = "Ifro";
        CE.Depositar(5000);
        CE.Sacar(9000);

        ContaEmpresarial CEM = new ContaEmpresarial();
        CEM.nConta = 2;
        CEM.Agencia = "002";
        CEM.Titular = "Josemar Victor Pereira da Silva";
        CEM.Saldo = 2000;
        CEM.Depositar(5000);
        CEM.Anuidade = 3000;
        CEM.LimiteEmprestimo = 1000;
        CEM.TotalEmprestimo = 1000;
        CEM.FazerEmprestimo(1500);
        CEM.Sacar(500);
    }
}











