using System;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.Nome = "Larissa";
            System.Console.WriteLine(cpf.Saudar());
            cpf.Cpf = "505674718-10";
            System.Console.WriteLine(cpf.ValidarCpf());

            CNPJ cnpj = new CNPJ();
            cnpj.Cnpj = "125465464";
            System.Console.WriteLine(cnpj.ValidarCnpj());
        }
    }
}
