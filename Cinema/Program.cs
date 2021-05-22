using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[150];
            string nome, cancelarpoltrona;
            int opção = 0, poltronaescolhida = 0, fatura = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = "vazia";

            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("poltrona {0}: {1} ", i, vetor[i]);
            }

            do
            {
                Console.WriteLine("digite 1 para fazer reserva da poltrona ");
                Console.WriteLine("digite 2 para cancelar reservas");
                Console.WriteLine("digite 3 para exibir a fatura");
                Console.WriteLine("digita 4 para consultar poltrona");
                Console.WriteLine("digite 5 para sair");
                opção = int.Parse(Console.ReadLine());

                if (opção == 1)
                {
                    Console.WriteLine("Informe a poltrona");
                    poltronaescolhida = int.Parse(Console.ReadLine());
                    if (vetor[poltronaescolhida] != "vazia")
                    {
                        Console.WriteLine("Poltrona ocupada");
                    }
                    else
                    {
                        Console.WriteLine("Informe seu nome: ");
                        nome = Console.ReadLine();
                        vetor[poltronaescolhida] = nome;
                    }
                }


                if (opção == 2)
                {
                    Console.WriteLine("escolha poltrona de 0 a 149 para ser cancelada");
                    poltronaescolhida = int.Parse(Console.ReadLine());
                    for (int i = 0; i < vetor.Length; i++)
                    {
                        if (vetor[poltronaescolhida] == "vazia")
                        {
                            Console.WriteLine("Poltrona vazia, escolha outra");
                        }
                        if (vetor[poltronaescolhida] != "vazia")
                        {
                            Console.WriteLine("poltrona {0} ", vetor[poltronaescolhida]);
                            Console.WriteLine("Deseja cancelar S/N ");
                            cancelarpoltrona = Console.ReadLine();
                            if (cancelarpoltrona == "S")
                            {
                                vetor[poltronaescolhida] = "vazia";
                            }
                            else
                            {
                                Console.WriteLine("Cancelamento não realizado");
                            }
                            break;
                        }
                    }

                }


                if (opção == 3)
                {
                    for (int i = 0; i < vetor.Length; i++)
                    {
                        if (i <= 49 && vetor[i] != "vazia")
                        {
                            fatura = fatura + 450;
                        }

                        else if (i >= 50 && i <= 100 && vetor[i] != "vazia")
                        {
                            fatura = fatura + 250;
                        }

                        else if (i >= 100 && vetor[i] != "vazia")
                        {
                            fatura = fatura + 150;
                        }

                    }
                    Console.WriteLine(" O Faturamento é : {0}$", fatura);
                    fatura = 0;

                }

                if (opção == 4)
                {
                    for (int i = 0; i < vetor.Length; i++)
                    {
                        if (vetor[i] != "vazia")
                        {
                            Console.WriteLine("poltrona {0}: {1} ", i, vetor[i]);
                        }
                    }
                }
                if (opção == 5)
                    for (int i = 0; i < vetor.Length; i++)
                    {
                        Console.WriteLine("poltrona {0}: {1} ", i, vetor[i]);
                    }
            } while (opção != 5);




        }
    }
}
