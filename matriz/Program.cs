using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*/
            //exerc 3
            int contador=0;
            double notas = 0;
            string nome = "";
            double media=0;
            int somarrr=0;
            media=notas;
            do
            {
                Console.WriteLine("Informe seu nome: ");
                nome = (Console.ReadLine());

                Console.WriteLine("Informe a nota");
                notas = double.Parse(Console.ReadLine());
                
                media=notas+1;
                if (notas>7)
                {
                    somarrr= somarrr +1;
                }

                

                if (contador<20)
                {
                    contador= contador +1;
                }

                if (contador>=20)
                {
                    break;
                }

            } while (contador<20);

            Console.WriteLine("Media da nota dos alunos=={0}, os que passaram== {1}",media/20,somarrr);
            /*/
            /*  1) Escreva um programa que leia uma matriz de dimensões arbitrárias
             (m linhas e n colunas) e crie um vetor (m elementos) com a soma dos elementos de uma mesma linha (exercício 2 da Aula 6 - matriz);  */
            /*/
           int[,] matriz = new int[,] { { 1, 2, 3 }, { 7, 5, 6 }, { 11, 8, 14 }, { 15, 9, 20 } };
           int[] vetor = new int[1];
           int soma = 0;

           for (int i = 0; i < vetor.Length; i++)
           {

               for (int m = 0; m < matriz.GetLength(0); m++)
               {

                   for (int n = 0; n < matriz.GetLength(1); n++)
                   {
                       Console.WriteLine("\t" + matriz[m, n]);
                   }
                   for (int n = 0; n < matriz.GetLength(1); n++)
                   {
                       soma = soma + matriz[m, n];
                   }
                   Console.WriteLine("  =  {0}  ", soma);
                   soma = 0;

               }
           }
           /*/
            /* 2) Escreva um programa que leia uma matriz de 5 linhas e 5 colunas, de caracteres (string), solicitando os elementos ao usuário.
            Verifique, a seguir, quais os elementos de A que estão repetidos e quantas vezes cada um está repetido.
             Escrever cada elemento repetido com uma mensagem dizendo que o elemento aparece X vezes (exercício 3 da Aula 6 - matriz);  */
            
            /*/
           string[,] a = new string[5, 5];
           string[,] b = new string[25, 2];
           int junç = 0;

           for (int m = 0; m < a.GetLength(0); m++)
           {
               for (int n = 0; n < a.GetLength(1); n++)
               {
                   Console.WriteLine(" Insira os elementos da Matriz: ");
                   a[m, n] = Console.ReadLine();

                   int subt = -1;
                   for (int i = 0; i < 25; i++)
                   {
                       if (a[m, n] == b[i, 0])
                       {
                           subt = i;
                           break;
                       }
                   }
                   if (subt == -1)
                   {
                       b[junç, 0] = a[m, n];
                       b[junç, 1] = "1";
                       junç = junç + 1;
                   }
                   else
                   {
                       var resultado = Convert.ToInt32(b[subt, 1]) + 1;
                       b[subt, 1] = resultado.ToString();
                   }
               }
           }
           for (int i = 0; i < junç; i++)
           {
               Console.WriteLine(" Os Valores são: {0} {1}", b[i, 0], b[i, 1]);
           }
           /*/

            /* 4) Escreva um algoritmo para ler uma matriz de 5 x 5 inteiros. Após isto,
          deverá ser lido mais um inteiro qualquer e verificar se esse número existe na matriz ou não. Informe as posições onde esse número aparece;  */

        }
    }
}