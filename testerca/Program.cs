using System;

namespace testerca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quest.1
             /*/  
            int n=0;
            Console.Write("Informe um valor: ");
            n=int.Parse(Console.ReadLine());
            
            if(n>0)
            {
                Console.WriteLine("Esse numero é positivo");
            }
            
            else
            {
                if(n<0)
                {
                Console.WriteLine("Esse numero é negativo");
                }
                else
                {
                    Console.WriteLine("Esse número é nulo");
                }
            } 
            /*/

            //Quest.2

            /*/
            int n1,n2,n3;
            int maior=0;
            Console.Write("Informe o primeiro valor: ");
            n1=int.Parse(Console.ReadLine());
            maior=n1;

            Console.Write("Informe o segundo valor: ");
            n2=int.Parse(Console.ReadLine());
            maior=n2;

            Console.Write("Informe o terceiro valor: ");
            n3=int.Parse(Console.ReadLine());
            maior=n3;

            if(n1>maior)
            {
                maior=n1;
            }
            if(n2>maior)
            {
                maior=n2;
            }
            if(n3>maior)
            {
                maior=n3;
            }
            Console.WriteLine("O numero maior é: {0}", maior);
            /*/

            //Quest.3

            /*/
            int n4=0,n5=0,n6=0;
            int mmaior=0,medio=0,mmenor=0;
            Console.Write("Informe um valor: ");
            n4=int.Parse(Console.ReadLine());
            mmaior=n4;
            medio=n4;
            mmenor=n4;

            Console.Write("Informe um valor: ");
            n5=int.Parse(Console.ReadLine());
            mmaior=n5;
            medio=n5;
            mmenor=n5;

            Console.Write("Informe um valor: ");
            n6=int.Parse(Console.ReadLine());
            mmaior=n6;
            medio=n6;
            mmenor=n6;

            //primeiro if Menor
            if(n4<mmenor)
            {
                mmenor=n4;
            }
            if(n5<mmenor)
            {
                mmenor=n5;
            }
            if(n6<mmenor)
            {
                mmenor=n6;
            }
            //segundo if numeros entre menor e maior
            //n4
            if((n4>n5)&& (n4<n6))
            {
                medio=n4;
            }
            if((n4<n5)&& (n4>n6))
            {
                medio=n4;
            }
            //n5
            if((n5>n4)&&(n5<n6))
            {
                medio=n5;
            }
            if((n5<n4)&&(n5>n6))
            {
                medio=n5;
            }
            //n6
            if((n6>n4)&&(n6<n5))
            {
                medio=n6;
            }
            if((n6<n4)&&(n6>n5))
            {
                medio=n6;
            }
            
            //terceiro if Maior
             if(n4>mmaior)
            {
                mmaior=n4;
            }
            if(n5>mmaior)
            {
                mmaior=n5;
            }
            if(n6>mmaior)
            {
                mmaior=n6;
            }
            Console.WriteLine("{0}<{1}<{2}", mmenor,medio,mmaior);
            /*/

            //Quest.4

            /*/
            //Mes de Março
            int semana;
            Console.Write("Digite o numero da semana: ");
            semana=int.Parse(Console.ReadLine());
            if((semana==1)||(semana==8)||(semana==15)||(semana==22)||(semana==29))
            {
                Console.WriteLine("{0} é Domingo",semana);
            }
             if((semana==2)||(semana==9)||(semana==16)||(semana==23)||(semana==30))
            {
                Console.WriteLine("{0} é segunda-feira",semana);
            }
             if((semana==3)||(semana==10)||(semana==17)||(semana==24)||(semana==31))
            {
                Console.WriteLine("{0} é terça-feira",semana);
            }
             if((semana==4)||(semana==11)||(semana==18)||(semana==25))
            {
                Console.WriteLine("{0} é quarta-feira",semana);
            }
             if((semana==5)||(semana==12)||(semana==19)||(semana==26))
            {
                Console.WriteLine("{0} é quinta-feira",semana);
            }
             if((semana==6)||(semana==13)||(semana==20)||(semana==27))
            {
                Console.WriteLine("{0} é sexta-feira",semana);
            }
             if((semana==7)||(semana==14)||(semana==21)||(semana==28))
            {
                Console.WriteLine("{0} é sábado",semana);
            }
            /*/

            //Quest.5

            /*/
            int mes;
            mes=31;
            string nome=("janeiro");
            string nome2=("fevereiro");
            string nome3=("março");
            string nome4=("abril");
            string nome5=("maio");
            string nome6=("junho");
            string nome7=("julho");
            string nome8=("agosto");
            string nome9=("setembro");
            string nome10=("outubro");
            string nome11=("novembro");
            string nome12=("dezembro");
            string v;
            Console.Write("Informe o mês: ");
            v=Console.ReadLine();

            if(v==nome)
            {
                Console.WriteLine("{0} tem {1} dias",nome,mes);
            }
            if(v==nome2)
            {
                Console.WriteLine("{0} tem {1} ou {2} dias",nome2,mes-3,mes-2);
            }
            if(v==nome3)
            {
                Console.WriteLine("{0} tem {1} dias",nome3,mes);
            }
            if(v==nome4)
            {
                Console.WriteLine("{0} tem {1} dias",nome4,mes-1);
            }
            if(v==nome5)
            {
                Console.WriteLine("{0} tem {1} dias",nome5,mes);
            }
            if(v==nome6)
            {
                Console.WriteLine("{0} tem {1} dias",nome6,mes-1);
            }
            if(v==nome7)
            {
                Console.WriteLine("{0} tem {1} dias",nome7,mes);
            }
            if(v==nome8)
            {
                Console.WriteLine("{0} tem {1} dias",nome8,mes);
            }
            if(v==nome9)
            {
                Console.WriteLine("{0} tem {1} dias",nome9,mes-1);
            }
            if(v==nome10)
            {
                Console.WriteLine("{0} tem {1} dias",nome10,mes);
            }
            if(v==nome11)
            {
                Console.WriteLine("{0} tem {1} dias",nome11,mes-1);
            }
            if(v==nome12)
            {
                Console.WriteLine("{0} tem {1} dias",nome12,mes);
            }
            /*/

            //Quest.6

            /*/
            int mat;
            Console.Write("informe um valor: ");
            mat=int.Parse(Console.ReadLine());
            Console.WriteLine("{0}x1={1}",mat,mat*1);
            Console.WriteLine("{0}x2={1}",mat,mat*2);
            Console.WriteLine("{0}x3={1}",mat,mat*3);
            Console.WriteLine("{0}x4={1}",mat,mat*4);
            Console.WriteLine("{0}x5={1}",mat,mat*5);
            Console.WriteLine("{0}x6={1}",mat,mat*6);
            Console.WriteLine("{0}x7={1}",mat,mat*7);
            Console.WriteLine("{0}x8={1}",mat,mat*8);
            Console.WriteLine("{0}x9={1}",mat,mat*9);
            Console.WriteLine("{0}x10={1}",mat,mat*10);
            /*/
            
            }
            

        
        }
    }

