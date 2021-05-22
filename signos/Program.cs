using System;

namespace signos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] signos = new string[12, 3];

            signos[0, 0] = "Áries";
            signos[1, 0] = "Touro";
            signos[2, 0] = "Gêmeos";
            signos[3, 0] = "Câncer";
            signos[4, 0] = "Leão";
            signos[5, 0] = "Virgem";
            signos[6, 0] = "Libra";
            signos[7, 0] = "Escorpião";
            signos[8, 0] = "Sagitário";
            signos[9, 0] = "Capricórnio";
            signos[10, 0] = "Aquário";
            signos[11, 0] = "Peixes";


            signos[0, 1] = "Fogo";
            signos[1, 1] = "Terra";
            signos[2, 1] = "Ar";
            signos[3, 1] = "Água";
            signos[4, 1] = "Fogo";
            signos[5, 1] = "Terra";
            signos[6, 1] = "Ar";
            signos[7, 1] = "Água";
            signos[8, 1] = "Fogo";
            signos[9, 1] = "Terra";
            signos[10, 1] = "Ar";
            signos[11, 1] = "Água";

            signos[0, 2] = "Marte";
            signos[1, 2] = "Vênus";
            signos[2, 2] = "Mercúrio";
            signos[3, 2] = "Lua";
            signos[4, 2] = "Sol";
            signos[5, 2] = "Mercúrio";
            signos[6, 2] = "Vênus";
            signos[7, 2] = "Plutão";
            signos[8, 2] = "Júpiter";
            signos[9, 2] = "Saturno";
            signos[10, 2] = "Urano";
            signos[11, 2] = "Neptuno";

            DateTime date_new = DateTime.Now;
            DateTime nascM, nascF;
            int diaM, mesM, anoM, diaF, mesF, anoF;
            int idadeM, idadeF, signoM, signoF;
            string op;

            do
            {
                Console.Clear();

                Console.WriteLine("\t\t Encontre o seu par de acordo com a compatibilidade dos signos do zodíaco ");
                Console.WriteLine();

                Console.Write(" Insira a data de nascimento do Homem: ");
                nascM = Convert.ToDateTime(Console.ReadLine());

                Console.Write(" Insira a data de nascimento da Mulher: ");
                nascF = Convert.ToDateTime(Console.ReadLine());

                diaM = nascM.Day;
                mesM = nascM.Month;
                anoM = nascM.Year;

                diaF = nascF.Day;
                mesF = nascF.Month;
                anoF = nascF.Year;

                idadeM = MetodoIdade(diaM, mesM, anoM);
                idadeF = MetodoIdade(diaF, mesF, anoF);

                signoM = MetodoSigno(diaM, mesM);
                signoF = MetodoSigno(diaF, mesF);

                Console.WriteLine("\n O Homem tem {0} anos de idade ", idadeM);
                Console.WriteLine(" Ele é do signo de {0}, Seu elemento é {1} e seu planeta é {2} ", signos[signoM, 0], signos[signoM, 1], signos[signoM, 2]);

                Console.WriteLine("\n A Mulher tem {0} anos de idade ", idadeF);
                Console.WriteLine("Ela é do signo de {0}, Seu elemento é {1} e seu planeta é {2}", signos[signoF, 0], signos[signoF, 1], signos[signoF, 2]);

                if (signos[signoM, 1].Equals(signos[signoF, 1]))
                    Console.WriteLine("\n De acordo com a compatibilidade dos signos o casal é compatível, \n pois são regidos pelo mesmo elemento {0}", signos[signoM, 1]);

                else
                    Console.WriteLine("\n De acordo com a compatibilidade dos signos o casal é incompatível, \n pois o Homem é regido pelo elemento {0} e a Mulher pelo elemento {1}", signos[signoM, 1], signos[signoF, 1]);

                Console.Write("\n Digite 'S' caso queira acessar a tabela do zodíaco ou outra tecla para sair: ");
                op = Console.ReadLine();

                switch (op)
                {
                    case "S":
                    case "s":
                        Console.Clear();
                        Console.WriteLine("\n Tabela dos zodíacos \n");

                        for (int l = 0; l <= 11; l++)
                        {
                            Console.WriteLine(" Signo {0} Elemento {1} Planeta {2} ", signos[l, 0], signos[l, 1], signos[l, 2]);
                        }
                        break;

                    default:
                        break;
                }

                Console.Write("\n Deseja Consultar a compatibilidade de outro casal? digite S/N: ");
                op = Console.ReadLine();

            } while (op == "S" || op == "s");

        }


        static int MetodoIdade(int dias, int meses, int anos)
        {
            DateTime date_new = DateTime.Now;
            int idadesMetodo;

            idadesMetodo = date_new.Year - anos;

            if (date_new.Month < meses)
                return (idadesMetodo - 1);

            else if (date_new.Month > meses)
                return idadesMetodo;

            else
                return (date_new.Day < dias) ? (idadesMetodo - 1) : (idadesMetodo);
        }

        static int MetodoSigno(int day_s, int month_s)
        {
            int indice = 0;

            if ((day_s >= 21 && month_s == 3) || (day_s <= 20 && month_s == 4))
                indice = 0;

            else if ((day_s >= 21 && month_s == 4) || (day_s <= 21 && month_s == 5))
                indice = 1;

            else if ((day_s >= 22 && month_s == 5) || (day_s <= 21 && month_s == 6))
                indice = 2;

            else if ((day_s >= 21 && month_s == 6) || (day_s <= 23 && month_s == 7))
                indice = 3;

            else if ((day_s >= 24 && month_s == 7) || (day_s <= 23 && month_s == 8))
                indice = 4;

            else if ((day_s >= 24 && month_s == 8) || (day_s <= 23 && month_s == 9))
                indice = 5;

            else if ((day_s >= 24 && month_s == 9) || (day_s <= 23 && month_s == 10))
                indice = 6;

            else if ((day_s >= 24 && month_s == 10) || (day_s <= 22 && month_s == 11))
                indice = 7;
            else if ((day_s >= 23 && month_s == 11) || (day_s <= 21 && month_s == 12))
                indice = 8;

            else if ((day_s >= 22 && month_s == 12) || (day_s <= 20 && month_s == 1))
                indice = 9;

            else if ((day_s >= 21 && month_s == 1) || (day_s <= 19 && month_s == 2))
                indice = 10;

            else if ((day_s >= 20 && month_s == 2) || (day_s <= 20 && month_s == 3))
                indice = 11;

            return indice;
        }
    }
}

