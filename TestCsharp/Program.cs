using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=0, cont=0;
            bool ok = false;
            string palavra = "", SN = "";
            do
            {
                try
                {
                    do
                    {
                        ok = false;

                        Console.Clear(); 
                        Console.WriteLine("***PRODUTOS***");
                        Console.WriteLine("1. Cadastrar");
                        Console.WriteLine("2. Listagem");
                        Console.WriteLine("3. Listagem Resumida");
                        Console.WriteLine("4. Consultar");
                        Console.WriteLine("5. Sair");
                        op = int.Parse(Console.ReadLine());

                        if (op< 1 || op> 5)
                        {
                            Console.WriteLine("Opção inválida, digitar apenas uma das opções disponíveis!");
                            Console.ReadKey();
                            ok = true;
                        }
                    } while (ok == true);

                    pp produto = new pp();

                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Opção 1 Escolhida ");
                            Console.WriteLine();
                            Console.Write("Digite o codigo:  ");

                            cont = int.Parse(Console.ReadLine());
                            

                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine(" Opção 2 Escolhida ");
                            Console.WriteLine();
                            
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine(" Opção 2 Escolhida ");
                            Console.WriteLine();
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine(" Opção 2 Escolhida ");
                            Console.WriteLine();

                            break;
                        case 5:
                            Console.WriteLine();
                            Console.WriteLine("Finalizando..");
                            Console.ReadKey();
                            ok = true;

                            break;
                    }
                    if (op != 5)
                    {

                        Console.Write("Deseja Repetir a operação? ( S / N ) - ");
                        SN = Console.ReadLine();

                        if (SN.ToUpper() == "N")
                        {
                            ok = true;

                            Console.WriteLine("Finalizando...");
                            Console.ReadKey();
                        }
                    }
                
                }
                catch (Exception)
                {

                    Console.WriteLine("");
                }
                
            } while(!ok);
            Console.ReadKey(); 
        }
    }
}
