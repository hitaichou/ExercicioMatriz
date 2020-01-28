using System;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um número inteiro N e uma matriz de
             ordem N contendo números inteiros. Em seguida, mostrar a diagonal
             principal e a quantidade de valores negativos da matriz.
             */

            int n = int.Parse(Console.ReadLine());

            //instanciando uma matriz NxN
            int[,] mat = new int[n, n]; 

            for(int i = 0; i < n; i++) //percorrendo as linhas
            {
                string[] valor = Console.ReadLine().Split(' '); //usando o split para capturar o dado e usando espaço como separador

                for(int x = 0; x < n; x++) //percorrendo as colunas
                {
                    //a matriz na posição Linha(i), Coluna(x) recebe o int do vetor Valor na posição X
                    mat[i, x] = int.Parse(valor[x]); //converte o string para inteiro
                }
            }
            Console.WriteLine("Diagonal Principal:");
            //para acessar a diagonal da matriz
            for (int i = 0; i< n; i++)
            {
                Console.Write(mat[i,i] + " ");
                Console.WriteLine();
            }

            
            //Para capturar os números negativos na matriz, é necessário percorrer toda a matriz novamente
            //Usamos uma variável de controle para somar os números negativos
            int contagem = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        contagem++;
                    }                    
                }
            }
            Console.WriteLine("Números negativos: " + contagem);
        }
    }
}
