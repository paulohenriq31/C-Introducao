using System;

namespace Exercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            Console.Write ("Digite o valor que voce gostaria de converter em Fahrenheit: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (1.8 * celsius) + 32;

            Console.WriteLine("O valor de " +celsius+ "celsius em fahrenheit é :" +fahrenheit);
        }
    }
}