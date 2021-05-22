using System;

namespace projeto4
{
    class Program
    {
        static void Main(string[] args)
        {
            //if e else 
            //variação
            double n1;
            Console.Write("Informe um numero: ");
            n1=double.Parse(Console.ReadLine());
            
            double n2;
            Console.Write("Informe um numero: ");
            n2=double.Parse(Console.ReadLine());
            //operação
            string op;
            Console.Write("Informe a operação: ");
            op=Console.ReadLine();
            if(op=="+")
            {
                Console.WriteLine("Resultado é: {0}",n1+n2);
            }
            else
            {
                Console.WriteLine("Operação inexistente");
                Console.WriteLine("Por favor,utilize apenas  um simbolo");
            }
            if(op=="-")
            {
                Console.WriteLine("Resultado é: {0}",n1-n2);
            }
            if(op=="/")
            {
                Console.WriteLine("Resultado é: {0}",n1/n2);
            }
            if(op=="*")
            {
                Console.WriteLine("Operação usada : {0}{1}{2} ",n1,op,n2);
                Console.WriteLine("Resultado é: {0}",n1*n2);
            }
        }
    }
}
