using System;

namespace Exercicios9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variaveis como double
            double tecla1, tecla2, tecla3, tecla4, tecla5, mediaTotal;
            //pedindo para digitar os 5 numeros seguidos e ja convertendo para o tipo double
            Console.WriteLine("informe 5 numeros");
            tecla1 = Convert.ToDouble(Console.ReadLine());
            tecla2 = Convert.ToDouble(Console.ReadLine());
            tecla3 = Convert.ToDouble(Console.ReadLine());
            tecla4 = Convert.ToDouble(Console.ReadLine());
            tecla5 = Convert.ToDouble(Console.ReadLine());
            //calculando a nota
            mediaTotal = (tecla1 + tecla2 + tecla3 + tecla4 + tecla5)/5;
            //Exibindo o valor do calculo anterior
            Console.WriteLine("O valor da media total é: " + mediaTotal);
        }
    }
}
