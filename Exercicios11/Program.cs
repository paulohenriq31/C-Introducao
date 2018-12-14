using System;

namespace Exercicios11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variaveis no formato double
            double juros, capital, taxaEmprestimo, periodo;
            //Pedindo o valor do capital e o convertendo para double
            Console.WriteLine("Digite o capital");
            capital = Convert.ToDouble(Console.ReadLine());
            //Pedindo o valor da taxa e o convertendo para double
            Console.WriteLine("Digite a taxa do empresitimo");
            taxaEmprestimo = Convert.ToDouble(Console.ReadLine());
            //Pedindo o valor do periodo e o convertendo para double
            Console.WriteLine("Dite o periodo total");
            periodo = Convert.ToDouble(Console.ReadLine());
            //Calculando o valor do juros
            juros = (capital*(taxaEmprestimo/100)*periodo);
            //Exibindo o valor do caluclo acima
            Console.WriteLine("O vaor do juros será: R$"+juros);
            
        }
    }
}
