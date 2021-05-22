using System;

namespace bruno_fibonacci_recursiva
{
    class Program
    {
        public static int fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }

        }
        public static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Informe o valor de n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacci(n));

        }
    }
}
