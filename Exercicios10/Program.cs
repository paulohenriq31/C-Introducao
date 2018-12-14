using System;

namespace Exercicios10
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando as variaveis
            double custoFabrica, custoFinal, porcDistribuidor, porcImposto;
            //pedindo os valores e o convertendo para double
            Console.Write("Digite o valor de fabrica do veiculo: ");
            custoFabrica = Convert.ToDouble(Console.ReadLine());
            //pedindo os valores e o convertendo para double
            Console.Write("Digite o valor do porcento do distribuidor: ");
            porcDistribuidor = Convert.ToDouble(Console.ReadLine());
            //pedindo os valores e os convertendo para double
            Console.Write("Digite o valor do porcento de imposto: ");
            porcImposto = Convert.ToDouble(Console.ReadLine());
            //calculando o custo final
            custoFinal = custoFabrica + (custoFabrica * (porcDistribuidor/100)) + (custoFabrica * (porcImposto/100));
            //exibindo na tela o valor do calculo
            Console.WriteLine("O valor total do carro será: R$" +custoFinal);

        }
    }
}
