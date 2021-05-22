using System;

namespace boleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string dias, meses, anos, IdBanco, datas;
            decimal preço = 0;
            string codigo = "";
            DateTime Vencimento = DateTime.Now, DataAtual;
            bool op = false;

            DataAtual= DateTime.Now;
            Console.WriteLine("Data atual é: {0}",DataAtual);

            Console.Write("Insira um codigo de barra: ");
            codigo = Console.ReadLine();

            do
            {
                try
                {
                    op = true;
                    Console.Write("Digite qualquer data valida: ");
                    Vencimento = DateTime.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Data invalida, tecle algo");
                    op= false;
                    Console.ReadKey();
                }
            } while (!op);

            Console.WriteLine("Data: {0}", Vencimento);

            IdBanco = codigo.Substring(0, 3);
            dias = codigo.Substring(3, 2);
            meses= codigo.Substring(5, 2);
            anos = codigo.Substring(7, 4);

            preço = decimal.Parse(codigo.Substring(11)) / 100m;

            if (IdBanco == "001")
            {
                Console.WriteLine("Banco do Brasil");
            }
            else if (IdBanco == "237")
            {
                Console.WriteLine("Banco Bradesco");
            }
            else if (IdBanco == "341")
            {
                Console.WriteLine("Banco Itaú");
            }
            else
            {
                Console.WriteLine("Banco Desconhecido");
            }

            datas = dias + "/" + meses + "/" + anos;

            Console.WriteLine("Banco: {0}", IdBanco);

            Console.WriteLine("Data de Vencimento: {0}", datas);

            Console.WriteLine("Valor do boleto: {0:C}", preço);

            if (DataAtual< DateTime.Parse(datas))
            {
                Console.WriteLine("Valor a pagar {0:C}", preço);
            }
            else
            {
                Console.WriteLine("Valor a pagar {0:C}", preço * 1.2m);
            }
            Console.WriteLine(" Tecle algo para sair..");
            Console.ReadKey();
        
        }
    }
}
