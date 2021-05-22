using System;

namespace materia_nova_junho
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] Vetor= new int [10];
           
           for (int i = 0; i < Vetor.Length; i++)
           {
               Console.WriteLine("Informe o valor: ");
               Vetor[i]=int.Parse(Console.ReadLine());
           }
           for (int i = 0; i < Vetor.Length; i++)
           {
               Console.WriteLine("Vetor[{0}] = {1}",i,Vetor[i]);
           }      
                  
        }
    }
}
