using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Herança
{
    class Instrumento
    {
        protected string modelo { get; set; }
        protected decimal precoCusto { get; set; }
        protected decimal porLucro { get; set; }
        protected decimal precoVenda { get; set; }
        protected string Tipo { get; set; }
        protected Fornecedor DescForm { get; set; }



        public virtual void Entrada()
        {
            Console.Clear();

            Console.Write("Modelo: ");
            modelo = Console.ReadLine();

            Console.Write("Preço de Custo: ");
            precoCusto = decimal.Parse(Console.ReadLine());

            Console.Write("Preço de Lucro: ");
            porLucro = decimal.Parse(Console.ReadLine());

            Console.Write("Preço de Venda: ");
            precoVenda=decimal.Parse(Console.ReadLine());

            Console.Write("Fornecedor: ");
            Fornecedor fornecee = new Fornecedor();
            fornecee.Cadastrar();

            
            Console.Write("Tipo de Instrumento: ");
            Tipo = Console.ReadLine();

        }
        public virtual void Entrada(decimal dolar)
        {
            
        }
        public virtual void ListaCompleta()
        {
            StreamReader ler =new  StreamReader("Instrumento.txt");

            Console.WriteLine(ler.ReadToEnd());
            Console.ReadKey();
        }
        public virtual void ListaFornecedor()
        {
            StreamReader ler = new StreamReader("Fornecedor.txt");

            Console.WriteLine(ler.ReadToEnd());
            Console.ReadKey();
        }
        public virtual void Consulta(string modelo)
        {
            string linha;

            StreamReader ler = new StreamReader("Instrumento.txt");

            while (!ler.EndOfStream)
            {
                linha = ler.ReadLine();

                if (Equals(linha.Trim(), modelo.ToString().Trim())) 
                {
                    for (int i = 0; i < 9; i++)
                    {
                        linha = ler.ReadLine();
                        Console.WriteLine(linha);
                    }
                    
                    Console.ReadKey();
                    break;
                }
            }
            ler.Close();
            
        }
         
    }
}
