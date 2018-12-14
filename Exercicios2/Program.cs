using System;

namespace Exercicios2
{
    class Program
    {
        //calculoMedia5notas
        static void Main(string[] args)
        {
            //declara as variaveis no formato double
            double nota1, nota2, nota3, nota4, nota5, mediaAluno;
            //declara as variaveis no formato string
            string aluno;
            
            //escreve na tela "Escreva o nome do aluno"
            Console.Write("Escreva o nome do Aluno: ");
            //guarda a linha anterior na variavel aluno
            aluno = Console.ReadLine();
            //escreve na tela "Digite a primeira nota do" e usa a variavel aluno com o nome ja gravado nele
            Console.Write("Digite a primeira nota do " + aluno +": ");
            //convete o valor inserido anterior para o formato Double e guarda ela na variavel nota1
            nota1 = Convert.ToDouble(Console.ReadLine());
            //esta pedindo para inserir a segunda nota do aluno usando a variavel aluno para mostrar o nome gurdado nele
            Console.Write("Digite a segunda nota do "+ aluno+ ": ");
            //converte o valor inserido na ultima nota e converte ela no formato Double e guarda na variavel nota2
            nota2 = Convert.ToDouble(Console.ReadLine());
            //esta pedindo a terceira nota do aluno usando a variavel aluno para mostra o nome digitado anteriomente
            Console.Write("Digite a terceira nota do " + aluno + ": ");
            //converte o valor digitado anteriomente no formato Double e guarda ele na variavel nota3
            nota3 = Convert.ToDouble(Console.ReadLine());
            //esta pedido a quarta nota do aluno usando a variavel aluno para mostrar o nome guardado nela
            Console.Write("Digite a quarta nota do " + aluno + ": ");
            //converte o valor inserido anteriomente no formato Double e guarda na variavel nota4
            nota4 = Convert.ToDouble(Console.ReadLine());
            //esta pedindo a quinta nota do aluno usando a variavel aluno para mostrar o nome do aluno
            Console.Write("Digite a quinta nota do " +aluno+": ");
            //converte o valor inserido em Double e amazena na variavel nota5 
            nota5 = Convert.ToDouble(Console.ReadLine());
            //esta calculando a media do aluno somando as 5 notas inseridas anteriomente e as dividindo por 5
            mediaAluno = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
            //esta imprimindo o resultado do calculo anterior e mostrando na tela
            Console.Write("A media da nota do aluno: " + aluno + " é: " +mediaAluno);
        }
    }
}
