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
                for (int j = 0; j < m; j++)
                {
                    //Comparando se o valor da posição da linha e da coluna é menor que zero
                    if (mat[i, j] == x)
                    {
                        if (i > 0 && j > 0 && i != (n - 1) && j != (m - 1))
                        {
                            //Criando váriaveis para saber qual o número antes, depois, em cima e em baixo do número escolhido
                            int esquerdo = mat[i, j - 1];
                            int direito = mat[i, j + 1];
                            int acima = mat[i - 1, j];
                            int abaixo = mat[i + 1, j];

                            //Imprimindo cada número
                            Console.WriteLine("\n-------------------------------");
                            Console.WriteLine("Posição: " + i + "," + j);
                            Console.WriteLine("Número acima: " + acima);
                            Console.WriteLine("Número abaixo: " + abaixo);
                            Console.WriteLine("Número a direita: " + direito);
                            Console.WriteLine("Número a esquerda: " + esquerdo);
                            Console.WriteLine("-------------------------------");
                        }
                        else if (i == 0 && j ==0)
                        {
                            int direito = mat[i, j + 1];
                            int abaixo = mat[i + 1, j];

                            Console.WriteLine("\n-------------------------------");
                            Console.WriteLine("Posição: " + i + "," + j);
                            Console.WriteLine("Número abaixo: " + abaixo);
                            Console.WriteLine("Número a direita: " + direito);
                            Console.WriteLine("-------------------------------");
                        }
                        else if (i == (n-1) && j == (m-1))
                        {
                            int esquerdo = mat[i, j - 1];
                            int acima = mat[i - 1, j];

                            Console.WriteLine("\n-------------------------------");
                            Console.WriteLine("Posição: " + i + "," + j);
                            Console.WriteLine("Número acima: " + acima);
                            Console.WriteLine("Número a esquerda: " + esquerdo);
                            Console.WriteLine("-------------------------------");
                        }
                        else if (i == (n-1) && j == 0)
                        {
                            int direito = mat[i, j + 1];
                            int acima = mat[i - 1, j];

                            Console.WriteLine("\n-------------------------------");
                            Console.WriteLine("Posição: " + i + "," + j);
                            Console.WriteLine("Número acima: " + acima);
                            Console.WriteLine("Número a direita: " + direito);
                            Console.WriteLine("-------------------------------");
                        }
                        else if (i == 0 && j == (m - 1))
                        {
                            int esquerdo = mat[i, j - 1];
                            int abaixo = mat[i + 1, j];

                            Console.WriteLine("\n-------------------------------");
                            Console.WriteLine("Posição: " + i + "," + j);
                            Console.WriteLine("Número a esquerda: " + esquerdo);
                            Console.WriteLine("Número abaixo: " + abaixo);
                            Console.WriteLine("-------------------------------");
                        }               
                    }
                    /*else
                    {
                        //Imprimindo que o número escolhido não existe na matriz
                        Console.WriteLine("\nEste número não existe.");
                    }*/
                }
            }            
        }
    }
}
