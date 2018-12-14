using System;

namespace Exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando as variaveis
            int estoqueMaximo, estoqueMinino, estoqueMedia;
            //pedindo para digitar o valor MAXIMO do estoque
            Console.Write ("Digite a quantidade maxima do seu estoque: ");
            //convertendo o valor digitado em Int32 e amarzenando na variavel estoqueMaximo
            estoqueMaximo = Convert.ToInt32(Console.ReadLine());
            //pedindo para digitar o valor MINIMO do estoque
            Console.Write ("Digite a quantidade minima do seu estoque: ");
            //converterndo o valor digitado em Int32 e amarzenando na variavel estoqueMinimo
            estoqueMinino = Convert.ToInt32(Console.ReadLine());
            //calculando o estoque MAXIMO + MINIMO e dividindo por 2 o valor da soma sera amarzenado na variavel estoqueMedia 
            estoqueMedia = (estoqueMaximo + estoqueMinino) / 2;
            //este comando é para limpar o terminal (somente para estetica)
            Console.Clear();
            //esta mostrando o resultado que esta guardado na variavel estoqueMedia
            Console.WriteLine ("A quantidade media do seu estoque é: " + estoqueMedia);

        }
    }
}
