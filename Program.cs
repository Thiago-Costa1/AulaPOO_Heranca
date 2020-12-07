using System;
using POO_Heranca.Classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos a subclasse PessoaFisica
            PessoaFisica pf = new PessoaFisica();

            PessoaJuridica pj = new PessoaJuridica();

            // Atribuímos um cpf ao objeto
            pf.cpf = "000.000.000-0";
            pj.cnpj = "14.564.126/0001-01";
            pj.nome = "Matheus";
            pf.nome ="Thiago";

            // Chamamos nosso método de saudação dentro de um método de ConsoleReadLine
            Console.WriteLine(pf.DarBoasVindas(pf.nome) );

            // Chamamos nosso método de validação da Subclasse

    
            Console.WriteLine(pf.ValidarCPF (pf.cpf) );

            Console.WriteLine(pj.DarBoasVindas(pj.nome));

            Console.WriteLine(pj.ValidarCNPJ(pj.cnpj));


        }
    }
}
