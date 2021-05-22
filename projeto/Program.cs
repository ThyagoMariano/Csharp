using System;

namespace tt
{
    class Program
    {
        static void Main(string[] args)
        {
            //salario por Horas
            double salarioH;
            Console.WriteLine("Informe o Valor do salario: ");
            salarioH = double.Parse(Console.ReadLine());
            //Numero de aulas
            double numeroA;
            Console.WriteLine("Informe quantidade de aulas: ");
            numeroA = double.Parse(Console.ReadLine());
            //total salario= salario por horas + numero de aulas
            double totalsalario;
            
            totalsalario = (numeroA*salarioH);
            Console.WriteLine(totalsalario);
            //Salario dividido pela taxa inss
            double descontoInss;
            Console.WriteLine("Informe a taxa INSS: ");
            descontoInss = double.Parse(Console.ReadLine());
            //Conta final salario ganho 
            double salarioFixo;
            salarioFixo = totalsalario - (totalsalario * descontoInss/100);
            Console.WriteLine(salarioFixo);
        }
    }
}
