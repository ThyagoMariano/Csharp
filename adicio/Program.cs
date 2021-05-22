using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace adicio {

    class adicio {

        static void Main (string[] args) 
        {

            string words = "", SN = "";
            int opcao = 0;
            bool control = false;

            do {

                try {

                    do {
                        control = false;

                        Console.Clear ();
                        Console.WriteLine ("**  Dicionário de Verbos   **");
                        Console.Write (" Digite o número da Opção escolhida! ");
                        Console.WriteLine (" 1° [1]- Verbos: Português - Inglês");
                        Console.WriteLine (" 2° [2]- Verbos: Inglês - Português");
                        Console.WriteLine (" 3° [3]- Sair");
                        opcao = int.Parse (Console.ReadLine ());
                        Console.Clear ();

                        if (opcao < 1 || opcao > 3) {
                            Console.WriteLine (" Opção inválida... digite apenas uma das 3 opções válidas e disponíveis! ");
                            control = true;
                        }
                    } 

                    while (control == true);

                     dicionario Dic = new  dicionario ();

                    switch (opcao) {

                        case 1:
                            Console.WriteLine (" Opção [1] Escolhida ");
                            Console.WriteLine (" Digite um verbo em português: ");
                            words = Console.ReadLine();

                            Dic.PortuguesIngles (words);
                            break;

                        case 2:
                            Console.Clear ();
                            Console.WriteLine (" Opção [2] Escolhida ");
                            Console.Write (" Digite um verbo em Inglês: ");
                            words = Console.ReadLine ();

                            Dic.InglesPortugues (words);
                            break;

                        case 3:
                            Console.WriteLine (" Opção [3] Escolhida ");
                            Console.WriteLine (" Saindo... (caso queira repetir o procedimento <aperte alguma tecla>) ");
                            control = true;
                            break;
                    }
                    Console.Clear();

                    if (opcao != 3) {
                        Console.Write (" Confirme Por Gentileza Caso Queira Repetir o Procedimento? aperte [S] ou [N] ");
                        SN = Console.ReadLine ();

                        if (SN.ToUpper () == "N") {
                            control = true;
                            Console.WriteLine (" * Programa Finalizado Com Sucesso * ");
                        }
                    }
                } 
                catch {
                    Console.WriteLine (" [Aperte algum número] ");
                }
            } while (!control);
        }
    }
}