using System;

namespace bruno_fatorial_recursivaa
{
    class Program
    {
        public static int fatorial (int n)
        {
            if (n==0)
            {
                return 1;
            }
            else
            {
                return n*fatorial(n-1);
            }    
            
        }
        public static void Main(string[] args)
        {
            int n=0;
            Console.WriteLine("Informe o valor de n: ");
            n=int.Parse(Console.ReadLine());            
            Console.WriteLine(fatorial(n));
        }
    }
}
