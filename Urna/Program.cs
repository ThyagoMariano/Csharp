using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto = 0; int cont=0;
            string sn;
            do
            {
                Console.WriteLine("Informe o Voto: ");
                voto = int.Parse(Console.ReadLine());
                bool ok = false;

                string explicitString1 = voto.ToString();

                Urnaa urn = new Urnaa();

                ok = urn.Procurar(explicitString1.Trim());

                if (explicitString1 == "0000")
                {
                    Console.WriteLine("Voto em branco");
                }
                if (explicitString1 == "8888")
                {
                    urn.Listar();
                }
                if (explicitString1 == "9999")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Voto NULO");
                }

                do
                {
                     Console.Write("Confirmar Voto ? (S/N): ");
                       sn = Console.ReadLine();
                       if (sn.ToUpper() != "N" && sn.ToUpper() != "S")
                     Console.WriteLine("Opção Inválida!");
                  } while (sn.ToUpper() != "N" && sn.ToUpper() != "S");

            } while (sn.ToUpper() == "S");
            Console.ReadKey();
        }
    }
}
