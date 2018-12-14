using System;

namespace Exercicios7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variaveis em double
            double valor1, valor2, valor3, mediaTotal;
            //Pedindo o valor da primeira nota e Convertendo elas em Double
            Console.Write("digite a primeira nota: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            //Pedindo o valor da segunda nota e Convertendo ela em Double
            Console.Write("digite a segunda nota: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            //Pedindo o valor da terceira nota e Convertendo ela em Double
            Console.Write("digite a terceira nota: ");
            valor3 = Convert.ToInt32(Console.ReadLine());
            //Limpa a tela
            Console.Clear();
            //Calculando a media
            mediaTotal = (valor1 + valor2 + valor3)/3;
            //Exibindo os resultados
            Console.WriteLine("A nota total é: " +mediaTotal);

        }
    }
}
