using System;

namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inserindo e lendo o número de linhas
            Console.WriteLine("Insira o número de linhas: ");
            int n = int.Parse(Console.ReadLine());
            //Inserindo e lendo o número de colunas
            Console.WriteLine("Insira o número de colunas: ");
            int m = int.Parse(Console.ReadLine());

            //Criando a matriz com os valores de coluna e linha = n
            int[,] mat = new int[n, m];

            //Criando a repetição para adicionar os valores da matriz, colocando como parametro os valores de linhas menores que a variavel N
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Escreva os valores da " + (i + 1) + "º linha: ");
                //Lendo cada número da matriz
                string[] values = Console.ReadLine().Split(' ');

                //Criando a repetição para adicionar os valores da matriz, colocando como parametro os valores de colunas menores que a variavel N
                for (int j = 0; j < m; j++)
                {
                    //Lendo os valores para cada posição da matriz
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            //Pegando o número escolhido
            Console.WriteLine("Digite úm número: ");
            int x = int.Parse(Console.ReadLine());

            //Criando a repetição com o número de linhas menor q a variável N
            for (int i = 0; i < n; i++)
            {
                //Criando a repetição com o número de colunas menor q a variável N
                for (int j = 0; j < n; j++)
                {
                    //Comparando se o valor da posição da linha e da coluna é menor que zero
                    if (mat[i, j] == x)
                    {
                        //Criando váriaveis para saber qual o número antes, depois, em cima e em baixo do número escolhido
                        int esquerdo = mat[i, j - 1];
                        int direito = mat[i, j + 1];
                        int acima = mat[i - 1, j];
                        int abaixo = mat[i + 1, j];

                        /*if (esquerdo == null || direito == null || acima == null || abaixo == null)
                        {

                        }*/

                        //Imprimindo cada número
                        Console.WriteLine("\nNúmero acima: " + acima);
                        Console.WriteLine("Número abaixo: " + abaixo);
                        Console.WriteLine("Número a direita: " + direito);
                        Console.WriteLine("Número a esquerda: " + esquerdo);
                        Console.WriteLine("-------------------------------");
                    }
                    /*else
                    {
                        //Imprimindo que o número escolhido não existe na matriz
                        Console.WriteLine("\nEste número não existe.");
                    }*/
                }
            }


            /*
            //Criando a variavel
            int n = int.Parse(Console.ReadLine());

            //Criando a matriz com os valores de coluna e linha = n
            int[,] mat = new int[n, n];

            //Criando a repetição para adicionar os valores da matriz, colocando como parametro os valores de linhas menores que a variavel N
            for (int i = 0; i < n; i++)
            {
                //Lendo cada número da matriz
                string[] values = Console.ReadLine().Split(' ');

                //Criando a repetição para adicionar os valores da matriz, colocando como parametro os valores de colunas menores que a variavel N
                for (int j = 0; j < n; j++)
                {
                    //Lendo os valores para cada posição da matriz
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            
            //Imprimindo a informação da diagonal principal
            Console.WriteLine("Main diagonal: ");

            //Criando a repetição para pegar os valores da matriz principal
            for (int i = 0; i < n; i++)
            {
                //Imprimindo os valores que tem a coluna e a linha como valores iguais
                Console.Write(mat[i, i] + " ");
            }
            //Imprimindo uma linha em branco
            Console.WriteLine();

            //Criando variavel para contar os números negativos
            int count = 0;

            //Criando a repetição com o número de linhas menor q a variável N
            for (int i = 0; i < n; i++)
            {
                //Criando a repetição com o número de colunas menor q a variável N
                for (int j = 0; j < n; j++)
                {
                    //Comparando se o valor da posição da linha e da coluna é menor que zero
                    if (mat[i, j] < 0)
                    {
                        //Somando a variavel count + 1
                        count++;
                    }
                }
            }
            //Imprimindo quantos números negativos têm na matriz
            Console.WriteLine("Negative number: " + count);

            //--------------------------------------------------------------------

            */
        }
    }
}
