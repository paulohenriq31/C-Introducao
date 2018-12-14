using System;

namespace Exercicios8
{
    class Program
    {
        static void Main(string[] args)
        {
            int meses, dias = 30, totalDias;

            Console.Write("Digite quantos meses voce quer converter em dias: ");
            meses = Convert.ToInt32(Console.ReadLine());

            totalDias = meses * dias;

            Console.WriteLine("O valor de " + meses+ " meses em dias é " + totalDias);

        }
    }
}
