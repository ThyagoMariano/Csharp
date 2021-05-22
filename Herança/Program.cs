using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            const string tipo = "Corda";
            const string tipo2 = "Sopro";
            const string tipo3 = "Percussão";
            string modelo="";
            string consulta;
            do
            {
                
                Console.WriteLine("1.Corda");
                Console.WriteLine("2.Sopro");
                Console.WriteLine("3.Percussao");
                Console.WriteLine("4.Lista Completa");
                Console.WriteLine("5.Lista Fornecedor");
                Console.WriteLine("6.Consulta");
                Console.WriteLine("7. Sair");
                Console.WriteLine("");

                do
                {
                    op = int.Parse(Console.ReadLine());
                } while (op < 0 && op >7);

                switch (op)
                {
                    case 1:
                        CordaF corda = new CordaF(tipo);
                        corda.Entrada();


                        break;

                    case 2:
                        Soprof sopro = new Soprof(tipo2);
                        sopro.Entrada();

                        Fornecedor fornece2 = new Fornecedor();
                        fornece2.Cadastrar();

                        break;

                    case 3:
                        PercuF percus = new PercuF(tipo3);
                        percus.Entrada();

                        Fornecedor fornece3 = new Fornecedor();
                        fornece3.Cadastrar();

                        break;
                    case 4:
                        Instrumento instru = new Instrumento();
                        instru.ListaCompleta();
                        
                        break;
                    case 5:
                        Fornecedor fornece5 = new Fornecedor();
                        fornece5.ListaTudo();

                        break;
                    case 6:
                        Console.Write("Digite o nome do modelo para consulta: ");
                        consulta = Console.ReadLine();
                        Instrumento inst = new Instrumento();
                        inst.Consulta(modelo);


                        break;

                    case 7:
                        Console.WriteLine("Saindo...");

                        break;

                }
                
            } while (op !=7);
            
        }
    }
}
