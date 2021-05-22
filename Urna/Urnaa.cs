using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{
    class Urnaa
    {
        public String voto { get; set; }


        public bool  Procurar(string procura)
        {
            string linha="";
            bool ok = false;

            StreamReader ler = new StreamReader("Canditados.txt");
            while (!ler.EndOfStream)
            {
                linha = ler.ReadLine();
                
                if (linha.ToUpper().Trim() == procura.ToString().Trim())
                {
                    linha = ler.ReadLine();
                    voto = linha;
                    Console.WriteLine(linha);
                     
                    ok = true;
                    break;
                }

            }

            ler.Close();

            return ok;
        }
        public void Listar()
        {

            StreamReader ver = new StreamReader("Canditados.txt");

            Console.WriteLine(ver.ReadToEnd());
            Console.ReadKey();
            ver.Close();
        }

    }


}
