using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.nome = "Lucca";
            Console.WriteLine( cpf.Saudar());

            cpf.cpf = "234.456.543-32";
            Console.WriteLine(cpf.ValidarCPF());

        }
    }
}
