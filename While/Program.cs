using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça enquanto condição

            /*/
            double  v,v2;
            v=v2=0;
            Console.WriteLine("Informe o primeiro valor: ");
            v = double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Informe o segundo valor: ");
                v2 = double.Parse(Console.ReadLine());
                if (v2 == 0)
            {
                Console.WriteLine("0 não é possivel informe outro valor: ");
            }
            } while (v2 == 0);
            Console.WriteLine("{0} / {1} = {2}",v, v2, v/v2);
            /*/
            /*/
            double basse, altura;
            basse = altura = 0;
            
            do
            {
                Console.Write("Informe a base: ");
                basse = double.Parse(Console.ReadLine());
                if (basse <=0)
                {
                    Console.WriteLine("Informe um valor maior que 0");
                }
            } while (basse <= 0);

            do
            {
                Console.Write("Informe a altura: ");
                altura = double.Parse(Console.ReadLine());
                if (altura <=0)
                {
                    Console.WriteLine("Informe um valor maior que 0");
                }
            } while (altura <= 0);
            
            Console.WriteLine("area{0}",(basse*altura)/2);
            /*/
            /*/
            double valor = 0;
            do
            {
                Console.Write("Informe o valor: ");
                valor =double.Parse(Console.ReadLine());

                if (valor > 0)
                {
                    Console.WriteLine("Valor {0} ", valor);
                    Console.WriteLine("Quadrado {0} ", valor * valor);
                    Console.WriteLine("Cubo {0}", valor * valor * valor);
                    Console.WriteLine("Raiz Quadrada {0}", Math.Sqrt(valor) );

                }
                else
                {
                    Console.WriteLine("Saindo..");
                }
            } while (valor > 0);
            /*/

            double valor = 0, valor2 = 0;
            int auxilio;
            do
            {
                Console.Write("Informe o primeiro valor: ");
                valor = double.Parse(Console.ReadLine());
                Console.Write("Informe o segundo valor: ");
                valor2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Disque 1 para efetuar a Soma dos valores");
                Console.WriteLine("Disque 2 para efetuar a Multiplicação dos valores");
                Console.WriteLine("Disque 3 para efetuar a Subtração dos valores");
                Console.WriteLine("Disque 4 para efetuar a Divisão dos valores");
                Console.WriteLine("Disque 5 para elevar os valores ao quadrado ");
                Console.WriteLine("Disque 6 para elevar os valores ao Cubo ");
                Console.WriteLine("Se deseja sair disque 7");
                auxilio = int.Parse(Console.ReadLine());
                Console.WriteLine("Opção escolhida {0}", auxilio);
                
                if (auxilio == 1)
                {
                    Console.WriteLine("O Resultado é {0}", valor + valor2);
                }
                if (auxilio == 2)
                {
                    Console.WriteLine("O Resultado é {0}", valor * valor2);
                }
                if (auxilio == 3)
                {
                    Console.WriteLine("O Resultado é {0}", valor - valor2);
                }
                if (auxilio == 4)
                {
                    Console.WriteLine("O Resultado é {0}", valor / valor2);
                }
                if (auxilio == 5)
                {
                    Console.WriteLine("O Resultado é {0}", Math.Pow(valor, 2));
                }
                if (auxilio == 6)
                {
                    Console.WriteLine("O Resultado é {0}", Math.Pow(valor, 3));
                }
                if (auxilio == 7)
                {
                    Console.WriteLine("Saindo..♫☼");
                }
            } while (auxilio > 0 && auxilio < 7);

        }
    }
}
