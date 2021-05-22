using System;

namespace NotaFinal_divisão
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio Conjunção
        /*/
        double n=0,n2=0,n3=0,media=0;
        Console.Write("Insira a nota do Trabalho pratico: ");
        n=double.Parse(Console.ReadLine());
        Console.Write("Insira a nota do Teste: ");
        n2=double.Parse(Console.ReadLine());
        Console.Write("Insira a nota da Prova Bimestral: ");
        n3=double.Parse(Console.ReadLine());

        media=(n+n2+n3/3);
        Console.WriteLine(media);

        if((media>=8) && (media<=10))
        {
            Console.WriteLine("Conceito A");
        }
        
        else if(media>=7 && media<=7.9)
        {
            Console.WriteLine("Conceito B");
        }
        else if(media>=6 && media<=6.9)
        {
            Console.WriteLine("Conceito C");
        }
        else if(media>=5 && media<=5.9)
        {
            Console.WriteLine("Conceito D");
        }
        else if(media<=4.9)
        {
            Console.WriteLine("Conceito E");
        }
        /*/

        //Divisão no if
        int nn=0;
        Console.Write("Insira um valor inteiro: ");
        nn=int.Parse(Console.ReadLine());
        if(nn%3==0 || nn%7==0)
        {
            Console.WriteLine("Valor divisivel por 3 ou por 7");
        }
        
        }
    }
}
