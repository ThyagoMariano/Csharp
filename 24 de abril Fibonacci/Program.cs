using System;

namespace _24_de_abril
{
    class Program
    {
        static void Main(string[] args)
        {
           int valor=0;
           Console.Write("Informe a continuação: ");
           valor=int.Parse(Console.ReadLine());
           int n1=0;
           int n2=0;
           int soma=1;
           for (int i = 1; i <= valor; i++)
           {
               n1=n2;
               n2=soma;
               soma=n1+n2;
               Console.WriteLine(soma);
           
           }
        }
    }
}
