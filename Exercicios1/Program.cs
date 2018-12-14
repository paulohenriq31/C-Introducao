using System;

namespace Exercicios1
{
    class Program
    {
     //Faça um algorismo para somar dois numeros informado pelo usuario e multiplicar o resultado pelo primeiro numero. 10-min
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;

            //Imprime na tela a mensagem "Informe o 1º numero
            //Console.WriteLine Pula uma linha e execulta o proximo comando
            Console.WriteLine ("Informe o 1º numero: ");
            //Converte oque o usuario digitou em int32 e coloca na variavel numero1
            numero1 = Convert.ToInt32(Console.ReadLine());
            //Imprime na tela a mensagem "Informe o 2º numero
            //Console.Write continua o proximo comando na mesma linha
            Console.Write ("Infome o 2º numero: ");
            //Converte o'que o usuario digitou em int32 e coloca na variavel numero2
            numero2 = Convert.ToInt32(Console.ReadLine());
            //Calcula a soma entre os 2 numeros que foram digitados e multiplicar a soma pelo o primeiro numero
            resultado = (numero1 + numero2) * numero1;
            //Exibe na tela o resultado do calculo efetuado em cima
            Console.WriteLine(resultado);

        }
    }
}
