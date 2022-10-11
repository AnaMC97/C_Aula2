using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio  3.1//
            //string f;
            //Console.WriteLine("Introduza uma frase: ");
            //string f = Console.ReadLine();
            //Console.WriteLine(f.ToUpper()); //Maiusculas
            //Console.WriteLine(f.Substring(0, 1)); //Primeira letra
            //Console.WriteLine(f[0]); //Primeira Letra
            //Console.WriteLine(f.Length); //Quantidade de Caracteres
            //Exercicio 3.2//
            //int[] P = { };
            //string frase = "Lorem Ipsum dolor sit amet sit", add;
            //Console.WriteLine("Lorem Ipsum dolor sit amet sit");
            //int posicao = frase.IndexOf("amet"); //posição da palavra na string
            //Console.WriteLine("Introduza uma palavra: "); //inserir palavra antes da posição anterior
            //add = Console.ReadLine();
            //frase = frase.Insert(posicao, add);
            //Console.WriteLine(frase);
            //Exercicio 3.3//
            //string nomesAutores = "";

            //Exercicio  3.4//

            //Exercicio 3.5//
            int[] idades =  new int[5]; //{ 52, 18, 20, 30, 25 };

            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine("Introduza a idade aluno: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(idades);
            Console.WriteLine(idades[0]);
            Console.WriteLine(idades[idades.Length-1]-20); //pessoa mais velha



            //char[] idades = new char[5]; //{ 52, 18, 20, 30, 25 };
            /*Console.WriteLine("Introduza a idade do 1º aluno");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza a idade do 2º aluno");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza a idade do 3º aluno");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza a idade do 4º aluno");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza a idade do 5º aluno");
            int n5 = Convert.ToInt32(Console.ReadLine());

            if (n1 < n2 && n1 < n3 && n1 < n4 && n1 < n5)
            {
                Console.WriteLine("Pessoa mais nova é " + n1);
            }
            else if (n2 < n1 && n2 < n3 && n2 < n4 && n2 < n5)
            {
                Console.WriteLine("Pessoa mais nova é" + n2);
            }
            else if (n3 < n1 && n3 < n2 && n3 < n4 && n3 < n5)
            {
                Console.WriteLine("Pessoa mais nova é" + n3);
            }
            else if (n4 < n1 && n4 < n2 && n4 < n3 && n4 < n5)
            {
                Console.WriteLine("Pessoa mais nova é"+ n4);
            }
            else if (n5 < n1 && n5 < n2 && n5 < n3 && n5 < n4)
            {
                Console.WriteLine("Pessoa mais nova é "+ n5);
            }*/







        }
    }
}
