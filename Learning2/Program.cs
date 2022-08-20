using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercicio;
            bool continuar = true;

            //while (continuar == true)
            //{
            Console.WriteLine("\n =========== =========== =========== ");
            Console.WriteLine("\n\t - Bem vindo a segunda lista de exercícios para aprender C# -");


            Console.WriteLine("\n SUMÁRIO DE EXERCÍCIOS ");
            Console.WriteLine("\t 1. Matriz Diagonal Principal");
            //Console.WriteLine("\t 2. Média de salários.");
            //Console.WriteLine("\t 3. Matemágica.");
            //Console.WriteLine("\t 4. Estoque.");
            Console.WriteLine("\n Qual exercício deseja testar?");

            exercicio = int.Parse(Console.ReadLine());

            switch (exercicio)
            {

                case 1:
                    Console.WriteLine("\t\n ==== Matriz Diagonal ===== ");

                    Console.WriteLine("\t Qual será o tamanho da sua matriz quadrada?");
                    int n = 0;
                    n = int.Parse(Console.ReadLine());
                    int[,] matriz = new int[n, n]; //instanciamento da matriz
                    Console.WriteLine("\t Adicione os números da primeira linha da sua matriz " + n + " números por vez.");

                    for (int i = 0; i < n; i++)
                    {
                        string[] valores = Console.ReadLine().Split(' ');

                        for (int j = 0; j < n; j++)
                        {
                            matriz[i, j] = int.Parse(valores[j]);
                        }
                    }

                    Console.WriteLine("\t A diagonal da sua matriz é: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(matriz[i, i] + " ");
                    }


                    //Verificação de quantidade de números negativos
                    int negativos = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (matriz[i, j] < 0)
                            {
                                negativos++;
                            }
                        }
                    }
                    Console.WriteLine("\n\t Existem " + negativos + " número negativos.");
                    Console.ReadKey();
                    break;

                default:
                    break;
            }
            //}
        }
    }
}
