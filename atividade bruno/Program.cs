using System;

namespace atividade_bruno
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int Vcem = 0, Vcinquenta = 0, Vvinte = 0, Vdez = 0, Vcinco = 0, Vum = 0;

            Console.WriteLine("Insira o valor a ser retirado: ");
            valor = int.Parse(Console.ReadLine());

            while (valor > 0)
            {
                if (valor >= 100)
                {
                    valor = valor - 100;
                    Vcem = Vcem + 1;
                }
                else if (valor >= 50)
                {
                    valor = valor - 50;
                    Vcinquenta = Vcinquenta + 1;
                }
                else if (valor >= 20)
                {
                    valor = valor - 20;
                    Vvinte = Vvinte + 1;
                }
                else if (valor >= 10)
                {
                    valor = valor - 10;
                    Vdez = Vdez + 1;
                }
                else if (valor >= 5)
                {
                    valor = valor - 5;
                    Vcinco = Vcinco + 1;
                }
                else
                {
                    valor = valor - 1;
                    Vum = Vum + 1;
                }
            }
            Console.WriteLine("Número de cédulas de R$ 100: {0}", Vcem);
            Console.WriteLine("Número de cédulas de R$ 50: {0}", Vcinquenta);
            Console.WriteLine("Número de cédulas de R$ 20: {0}", Vvinte);
            Console.WriteLine("Número de cédulas de R$ 10: {0}", Vdez);
            Console.WriteLine("Número de cédulas de R$ 5: {0}", Vcinco);
            Console.WriteLine("Número de cédulas de R$ 1: {0}", Vum);
        }
    }
}
