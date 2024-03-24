using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitos1
{
    internal class Program
    {
        static int idade;
        static void Main(string[] args)
        {
            int idade = 42; //declaração do valor da variavel 
            Console.WriteLine("Seja bem-vindo a pratica 1"); //aparece a mensagem 
            Console.WriteLine("a idade informada foi " + idade); //mostra o valor da variavel 
            Console.WriteLine("pressione uma tecla para finalizar...");
            Console.ReadLine(); //o terminal permanece aberto para visualização
        }
    }
}
