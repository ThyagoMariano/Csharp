using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Fornecedor
    {
        protected string NomeFor{ get; set; }
        protected string NomeContator { get; set; }
        protected string FoneContato { get; set; }




        public void Cadastrar()
        {
            Console.WriteLine("Qual o nome: ");
            NomeFor=Console.ReadLine();
            Console.WriteLine("Qual o nome da empresa");
            NomeContator= Console.ReadLine();
            Console.WriteLine("Forma de contato");
            FoneContato= Console.ReadLine();

            StreamWriter gravar = new StreamWriter("Fornecedor.txt", true);

            gravar.WriteLine(NomeFor);
            gravar.WriteLine(NomeContator);
            gravar.WriteLine(FoneContato);
            gravar.Close();

        }
        public void ListaTudo()
        {
            StreamReader ler = new StreamReader("Fornecedor.txt");

            Console.WriteLine(ler.ReadToEnd());
            Console.ReadKey();
        }
        public  bool Consultar(string nomefor)
        {
            string linha;
            bool ok = false;

            StreamReader ler = new StreamReader("Fornecedor.txt");

            while (!ler.EndOfStream)
            {
                linha = ler.ReadLine();

                if (Equals(linha.Trim(), nomefor.ToString().Trim())) 
                {
                    for (int i = 0; i < 8; i++)
                    {
                        linha = ler.ReadLine();
                        Console.WriteLine(linha);
                    }
                    ok = true;
                    Console.ReadKey();
                    break;
                }
            }
            ler.Close();
            return ok;
        }
    }
}
