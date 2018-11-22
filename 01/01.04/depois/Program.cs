using System;

namespace _01_04
{
    class Program
    {
        delegate int Operacao(int a, int b);

        static void Main(string[] args)
        {
            Operacao operacao = (x, y) => x + y; //expressão lambda
            Console.WriteLine(operacao(3, 2));

            Func<int, int, int> somar = (x, y) => x + y;
            Console.WriteLine(somar(3, 2));

            Action<string> imprimirMensagem 
                = (mensagem) => 
                {
                    Console.WriteLine(mensagem);
                };

            imprimirMensagem("Olá, Alura!");

            Console.ReadKey();
        }
    }
}