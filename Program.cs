using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a senha!");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido.");
        }
    }
}