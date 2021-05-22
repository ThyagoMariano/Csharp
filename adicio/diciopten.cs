using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario
{

    class dicionario
    {

        public string Name { get; set; }

        public void PortuguesIngles(string words)
        {

            string line;
            bool control = false;

            StreamReader ler = new StreamReader("VerbosPortugues.txt");

            while (!ler.EndOfStream)
            {

                line = ler.ReadLine();

                if (line.Substring(0, line.IndexOf(" ")).ToUpper() == words.ToUpper())
                {
                    Console.WriteLine(line);
                    control = true;
                }
            }

            if (!control)
            {
                Console.WriteLine(" O Verbo Digitado Não Foi Encontrado!  Tente novamente... :)");
            }
            Console.Clear();
            ler.Close();
        }

        public void InglesPortugues(string words)
        {

            string line;
            bool control = false;

            StreamReader ler = new StreamReader("VerbosIngles.txt");

            while (!ler.EndOfStream)
            {
                line = ler.ReadLine();

                if (line.Substring(0, line.IndexOf(" ")).ToUpper() == words.ToUpper())
                {
                    Console.WriteLine(line);
                    control = true;
                }
            }
            if (!control)
            {
                Console.WriteLine(" O Verbo Digitado Não Foi Encontrado! Tente novamente... :)");
            }
            Console.Clear();
            ler.Close();
        }
    }
}