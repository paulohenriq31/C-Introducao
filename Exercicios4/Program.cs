using System;

namespace Exercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando as varias A, B, C sendo que A recebeu 999, B recebeu 555 e C ficou nulo
            int A = 999, B = 555, C;
            //exibindo os valores das variaveis na tela
            Console.WriteLine ("Valores de A = " +A+ ", B = " +B);
            //Transfere o valor de A para C
            C = A; //C=0 / A=999
            //Tranferindo o valor de B para A
            A = B; //A=999 / B=555
            //Transferindo o valor de C para B
            B = C; //B=555 / C=999
            //exibi os valores atualizados na tela
            Console.WriteLine ("Os valores atualizados são, A = " +A+ ", B = " +B);



        }
    }
}
