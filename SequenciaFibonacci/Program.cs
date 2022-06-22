using System;
using System.Collections.Generic;

namespace SequenciaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int indiceUltimoElemento = 1;
            int indicePenultimoElemento = 0;

            var sequenciaFibonacci = new List<int> { 0, 1 };

            Console.WriteLine("Digite um numero: ");

            var numeroInformado = int.Parse(Console.ReadLine());

            var pararWhile = true;

            while (pararWhile)
            {
                var proximoElemento = sequenciaFibonacci[indicePenultimoElemento] + sequenciaFibonacci[indiceUltimoElemento];

                sequenciaFibonacci.Add(proximoElemento);

                indiceUltimoElemento++;
                indicePenultimoElemento++;

                if (numeroInformado <= proximoElemento)
                    pararWhile = false;
            }

            if(sequenciaFibonacci.Any(a=> a == numeroInformado))
                Console.WriteLine("É um número da Sequência Fibonacci.");
            else
                Console.WriteLine("Não um número da Sequência Fibonacci.");
        }
    }
}
