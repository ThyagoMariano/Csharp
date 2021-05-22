using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class CordaF : Instrumento
    {
        protected string InstCorda { get; set; }
        protected string TipoCorda { get; set; }
        protected int NumCorda { get; set; }

        public CordaF(string tipo)
        {
            Tipo = tipo;
        }

        public override void Entrada()
        {
            base.Entrada();

            int indice = 1;
            string[] TipoCordas= new string[2];
            TipoCordas[0]= "Nylon";
            TipoCordas[1]= "Aço";

            foreach (string tipoC in TipoCordas)
            {
                Console.WriteLine("{0}. {1}", (indice++), tipoC);
            }

            do
            {
                indice = int.Parse(Console.ReadLine());

            } while (indice <= 0 || indice > 2);

            TipoCorda= TipoCordas[indice - 1];

            Console.Write("InstCorda: ");
            InstCorda = Console.ReadLine();

            Console.Write("número da corda: ");
            NumCorda = int.Parse(Console.ReadLine());


            StreamWriter gravar = new StreamWriter("Instrumento.txt", true);

            gravar.WriteLine($"{modelo};{precoCusto};{porLucro};{precoVenda};{Tipo};{DescForm};{InstCorda};{TipoCorda};{NumCorda}");
            
            gravar.Close();

            Console.WriteLine("Feito com sucesso!");
            Console.ReadKey();


        }
        public override void Entrada(decimal dolar)
        {

        }
        public override void ListaCompleta()
        {
            base.ListaCompleta();
        }
        private void Gravar()
        {

        }
    }
}
