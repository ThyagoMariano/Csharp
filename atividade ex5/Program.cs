using System;

namespace atividade_ex5
{
    class Program
    {
        static void Main(string[] args)
        {


            
            //EXERCICIO - 1
                  int l1 = 0, l2 = 0, l3 = 0;
            int solicitacao = 0;

            while (solicitacao != 2)
            {

                Console.WriteLine(" Digite 1 para inserir os lados do triangulo ");
                Console.WriteLine(" Digite 0 para sair ");
                solicitacao = int.Parse(Console.ReadLine());

                switch (solicitacao)
                {
                    case 1:
                        Console.WriteLine(" Inserira o lado A do triangulo ");
                        l1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Inserira o lado B do triangulo ");
                        l2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Inserira o lado C do triangulo ");
                        l3 = int.Parse(Console.ReadLine());
                        break;

                    case 0:
                        Console.WriteLine(" Exit System...");
                        return;
                }
                if (l1 == 0 ^ l2 == 0 ^ l3 == 0)
                {
                    Console.WriteLine("Triângulo inválido pois um ou todos os lados tem valor igual a 0");
                }
                else if (l1 > (l2 + l3) ^ l2 > (l1 + l3) ^ l3 > (l1 + l2))
                {
                    Console.WriteLine("Triângulo inválido pois um lado é maior do que a soma de dois lados");
                }
                if (l1 == l2 && l1 == l3)
                {
                    Console.WriteLine("Esse Triângulo é equilátero pois tem 3 lados iguais");
                }
                else if (l1 == l2 && l1 != l3 || l1 == l2 && l2 != l3 || l2 == l3 && l1 != l2 || l1 == l3 && l1 != l2)
                {
                    Console.WriteLine("Esse Triângulo é insóceles pois tem 2 lados iguais");
                }
                else if (l1 != l2 && l1 != l3 && l2 != l3)
                {
                    Console.WriteLine("Esse Triângulo é escaleno pois tem lados diferentes");
                }
                /*/




                //EXERCICIO 2
                /*/
                int valor_insert, Num_maior, Num_menor, Num_medio;
            int cont = 1;
            Console.WriteLine("Informe um Número: ");
            valor_insert = int.Parse(Console.ReadLine());
            Num_maior = valor_insert ;
            Num_menor = valor_insert ;
            Num_medio = valor_insert ;

            for (int i = 1; i != 0; i++)
            {
                Console.WriteLine("Informe um Número: ");
                valor_insert = int.Parse(Console.ReadLine());

                Num_medio = (Num_medio + valor_insert);
                cont++;

                if(valor_insert == 0)
                {
                    cont = cont - 1;
                    break;
                }
                else if (valor_insert != 0)
                if (valor_insert < Num_menor)
                {
                   Num_menor = valor_insert;
                }
                if (valor_insert > Num_maior)
                {
                    Num_maior = valor_insert;
                }
            }

            Console.WriteLine($"O maior número inserido é: { Num_maior}");
            Console.WriteLine($"O menor número inserido é: { Num_menor}");
            Console.WriteLine($"A media dos número inserido é: { Num_medio / cont}");
        }


                





           // Questão 3
           /*/
            double n, n2, n3;
            n = n2 = n3 = 0;
            double delta, raiz1, raiz2;
            delta = raiz1 = raiz2 = 0;

            Console.Write("Informe o valor de A: ");
            n = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de B: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de C: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("A equação é {0}x²+{1}x+{2}=0", n, n2, n3);
            //formula usada
            delta = n2 * n2 - 4 * n * n3;
            raiz1 = (-n2 + Math.Sqrt(delta)) / (2 * n);
            raiz2 = (-n2 - Math.Sqrt(delta)) / (2 * n);
            //situação do delta
            if (delta > 0)
            {
                Console.WriteLine("Primeira raiz: {0}", raiz1);
                Console.WriteLine("Segunda raiz: {0}", raiz2);
            }
            if (delta == 0)
            {
                Console.WriteLine("A única raiz existente é {0}", raiz1);
            }
            if (delta < 0)
            {
                Console.WriteLine("Não existe raizes reais");
            }
            




                                    //EXERCÍCIO 4
            int dia1, dia2, mes1, mes2, ano1, ano2;
            int ID_dia = 0, ID_mes = 0, ID_ano = 0;

            Console.WriteLine ("Informe o dia da 1° data");
            dia1 = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Informe o mes da 1° data");
            mes1 = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Informe o ano da 1° data");
            ano1 = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Informe o dia da 2° data");
            dia2 = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Informe o mes da 2° data");
            mes2 = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Informe o ano da 2° data");
            ano2 = int.Parse (Console.ReadLine ());

            if (dia1 > 30 || dia2 > 30) {
                Console.WriteLine ("Data Inválida");
                return;
            }
            if (mes1 > 12 || mes2 > 12) {
                Console.WriteLine ("Data Inválida");
                return;
            }
            if (ano1 < 1 || ano2 < 1) {
                Console.WriteLine ("Data Inválida");
                return;
            } else {
                if (dia1 >= dia2) {
                    ID_dia = dia1 - dia2;
                }
                if (dia1 < dia2) {
                    ID_dia = dia2 - dia1;
                }

                if (mes1 >= mes2) {
                    ID_mes = (mes1 - mes2) * 30;
                }
                if (mes1 < mes2) {
                    ID_mes = mes1 - mes2 * 30;
                }

                if (ano1 < ano2) {
                    ID_ano = (ano2 - ano1) * 360;
                }
                if (ano1 > ano2) {
                    Console.WriteLine ("Comparação Inválida1");
                }
                if (ano1 == ano2) {
                    if (mes1 > mes2) {
                        Console.WriteLine ("Comparação Inválida2");
                    }
                }
                int diferencaDias = ID_dia + ID_mes + ID_ano;
                Console.WriteLine ("A diferença entre as datas {0}/{1}/{2} e {3}/{4}/{5} é de {6} dias", dia1, mes1, ano1, dia2, mes2, ano2, diferencaDias);
            }
            /*/

        }
    }
}