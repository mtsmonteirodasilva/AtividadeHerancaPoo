using AtividadeHerancaPoo.Classes;
using System;
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
    }
}