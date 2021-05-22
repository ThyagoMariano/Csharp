using System;

namespace projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            //salario minimo   
            double salario;
        Console.Write("Informe o salario: ");
        salario = double.Parse(Console.ReadLine());
        //salario anual
         double salarioAnual;
         salarioAnual = salario*12;
         Console.Write("Salario anual: ");
         Console.WriteLine (salarioAnual);
         //horas trabalhadas
         double horasT;
         Console.Write("Informe as horas trabalhadas: ");
         horasT = double.Parse(Console.ReadLine());
         //Valor do produto
         double Produto;
         Console.Write("Informe o valor do produto: ");
         Produto = double.Parse(Console.ReadLine());
         //salario por hora
         double salarioPorH;
         salarioPorH = (salario/horasT);
         Console.Write("Salario  por Hora: ");
         Console.WriteLine(salarioPorH);
         //tempo de pegar o produto
         double temp;
         temp = (Produto/salarioPorH);
         Console.WriteLine(temp);

        }
    }
}
