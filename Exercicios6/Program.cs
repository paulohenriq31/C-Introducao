using System;

namespace Exercicios6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando a variavel
            int numero =0, antecessor=0, sucessor=0;
            //Pedindo para o usuario digitar um numero qualquer
            Console.WriteLine("Digite um numero");
            //Convertendo de String para Int32
            numero = Convert.ToInt32(Console.ReadLine());
            //Removendo -1 do numero digitado
            antecessor = numero -1;
            //Adicionando +1 no numero digitado
            sucessor = numero +1;
            //Exibindo na tela
            Console.WriteLine("O numero escolhido é " + numero + " o antecessor dele é " +antecessor + " e o sucessor é " + sucessor);


        }
    }
}
