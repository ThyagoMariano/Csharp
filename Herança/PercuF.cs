using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class PercuF : Instrumento
    {
        protected string TipoPerc { get; set; }
        protected string EquipPerc { get; set; }
        protected string EquipRec { get; set; }

        public PercuF(string tipo3)
        {
            Tipo = tipo3;
        }

        public override void Entrada()
        {
            base.Entrada();

            int indice = 1;
            string[] percussao = new string[2];
            percussao[0] = "gongo";
            percussao[1] = "berimbau";

            foreach (string percuss in percussao)
            {
                Console.WriteLine("{0}. {1}", (indice++), percuss);
            }

            do
            {
                indice = int.Parse(Console.ReadLine());

            } while (indice <= 0 || indice > 2);

            TipoPerc = percussao[indice - 1];

            Console.Write("EquipPercus: ");
            EquipPerc = Console.ReadLine();

            Console.Write("EquipRec: ");
            EquipRec = Console.ReadLine();

            StreamWriter gravar = new StreamWriter("Instrumento.txt", true);

            gravar.WriteLine($"{modelo};{precoCusto};{porLucro};{precoVenda};{Tipo};{DescForm};{TipoPerc};{EquipPerc};{EquipRec}");

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
