using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Soprof : Instrumento
    {
        protected string Tiposopro { get; set; }
        protected string ModeloBoquilha { get; set; }

        public Soprof(string tipo2)
        {
            Tipo = tipo2;
        }

        public override void Entrada()
        {
            base.Entrada();

            int indice = 1;
            string[] TipoSopros = new string[2];
            TipoSopros[0] = "Flauta";
            TipoSopros[1] = "Trompetes";

            foreach (string tipoSo in TipoSopros)
            {
                Console.WriteLine("{0}. {1}", (indice++), tipoSo);
            }

            do
            {
                indice = int.Parse(Console.ReadLine());

            } while (indice <= 0 || indice > 2);

            Tiposopro= TipoSopros[indice - 1];

            Console.Write("Modelo Boquilha: ");
            ModeloBoquilha= Console.ReadLine();

            StreamWriter gravar = new StreamWriter("Instrumento.txt", true);

            gravar.WriteLine($"{modelo};{precoCusto};{porLucro};{precoVenda};{Tipo};{DescForm};{Tiposopro};{ModeloBoquilha}");

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
