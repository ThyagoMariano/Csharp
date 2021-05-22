using System;

namespace _1_de_abril
{
    class Program
    {
        static void Main(string[] args)
        {//Quest.3
        /*/
            double sb=0;
            Console.Write("Insira o Salario Bruto: ");
            sb=double.Parse(Console.ReadLine());
            double vp=0;
            Console.Write("Insira o Valor da Prestação: ");
            vp=double.Parse(Console.ReadLine());
           if(vp>(sb*0.3))
           {
               Console.WriteLine("Emprestimo não conseguido");
           }
           else
           {
               Console.WriteLine("Emprestimo conseguido");
           }
           /*/
            //Quest.4
            /*/
            string nome;
            Console.Write("Insira Seu nome: ");
            nome=Console.ReadLine();
            string sexo;
            Console.Write("Insira seu sexo: ");
            sexo=Console.ReadLine();
            int idade=0;
            Console.Write("Insira Sua idade: ");
            idade=int.Parse(Console.ReadLine());
            if(sexo=="feminino" && idade<25)
            {
                Console.WriteLine("{0} ACEITA",nome);
            }
            else
            {
                Console.WriteLine("{0} Não ACEITA!",nome);
            }
            /*/
            //Quest.5
            /*/
            double salario=0;
            Console.Write("Insira o salario: ");
            salario=double.Parse(Console.ReadLine());
            if(salario<=1045)
            {
                Console.WriteLine("Desconto do Inss é de 7,5%");
            }
            if(salario>=1045.01 && salario<=2089.60)
            {
                Console.WriteLine("Desconto do Inss é de 9%");
            }
            if(salario>=2089.61 && salario<=30134.40)
            {
                Console.WriteLine("Desconto do Inss é de 12%");
            }
            if(salario>=3134.41 && salario<=6101.06)
            {
                Console.WriteLine("Desconto do Inss é de 14%");
            }
            /*/
            //Quest.6
            /*/
            double altura=0;
            Console.Write("Insira sua altura em metros: ");
            altura=double.Parse(Console.ReadLine());
    
            string sexo;
            Console.Write("Insira seu sexo: ");
            sexo=Console.ReadLine();

            if(sexo=="masculino" || sexo=="Masculino")
            {
                Console.Write("Seu peso ideal é {0}",(72.7*altura)- 58);
            }
            if(sexo=="feminino" || sexo== "Feminino")
            {
                Console.Write("Seu peso ideal é {0}",(62.1*altura)- 44.7);
            }
            /*/
            
            
        }
    }
}
