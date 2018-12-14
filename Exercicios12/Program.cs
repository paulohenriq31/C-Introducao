using System;

namespace Exercicios12
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando as variaveis
            double salario, reajuste, salarioReajuste;
            //Pedindo para digitar o valor do salario e o convertendo para double
            Console.WriteLine("Digite o valor do salario");
            salario = Convert.ToDouble(Console.ReadLine());
            //Pedindo para digitar o valor em porcetagem do reajuste
            Console.WriteLine("Digite o valor do reaguste");
            reajuste = Convert.ToDouble(Console.ReadLine());
            //calculando o reajsute
            salarioReajuste = salario * (reajuste/100) + salario;
            //Escrevendo na tela o resultado do calculo
            Console.WriteLine("O valor do salario com o ajuste será: R$" + salarioReajuste);
        }
    }
}
