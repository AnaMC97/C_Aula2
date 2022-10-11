using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio  3.1//
            string f;
            Console.WriteLine("Introduza uma frase: ");
            f = Console.ReadLine();
            Console.WriteLine(f.ToUpper()); //Maiusculas
            Console.WriteLine(f.Substring(0, 1)); //Primeira letra
            Console.WriteLine(f.Length); //Quantidade de Caracteres
            //Exercicio 3.2//
           // 2.Crie um programa em C#, que usando a string “Lorem Ipsum dolor sit amet sit” devolva 
            //para o ecrã:
            //a.A posição dentro da string da palavra “amet”;
            //b.Permita ao utilizador inserir uma frase antes da posição do ponto a).
            int[] P = { };
            string palavra = "Lorem Ipsum dolor sit amet sit", add;
            Console.WriteLine("Lorem Ipsum dolor sit amet sit");
            Console.WriteLine(palavra.IndexOf("amet")); //posição da palavra na string
            Console.WriteLine("Introduza uma frase: "); //inserir palavra antes da posição anterior
            add = Console.ReadLine();
            palavra.Insert(palavra.IndexOf("amet"), add);


        }
    }
}
