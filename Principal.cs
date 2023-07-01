using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOAT2.cs
{
    public  class Principal
    {

        public static void Main (string[] args)
        {

            int escolha;
           
            
            

            do
            {

                Console.WriteLine("Questão 1");
                Console.WriteLine("Questão 2");
                Console.WriteLine("Questão 3");
                Console.WriteLine("Questão 4");
                Console.WriteLine("Questão 5");
                Console.WriteLine("Questão 6");
                Console.WriteLine("Questão 7");
                Console.WriteLine("Questão 8");
                Console.WriteLine("Questão 9");
                Console.WriteLine("Questão 10");
                Console.WriteLine("Questão 11");
                Console.WriteLine("Questão 12");
                Console.WriteLine("Escolha uma questão");
                Console.WriteLine("Ou pressione 0 pra sair");

                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Exercicios op1 = new Exercicios();
                        op1.Questao1();


                        break;
                    case 2:
                        Exercicios op2 = new Exercicios();
                        op2.Questao2();
                        break;
                    case 3:
                        Exercicios op3 = new Exercicios();
                        op3.Questao3();
                        break;
                    case 4:
                        Exercicios op4 = new Exercicios();
                        op4.Questao4();
                        break;
                    case 5:
                        Exercicios op5 = new Exercicios();
                        op5.Questao5();
                        break;
                    case 6:
                        Exercicios op6 = new Exercicios();
                        op6.Questao6();
                        break;
                    case 7:
                        Exercicios op7 = new Exercicios();
                        op7.Questao7();
                        break;
                    case 8:
                        Exercicios op8 = new Exercicios();
                        op8.Questao8();
                        break;
                    case 9:
                        Exercicios op9 = new Exercicios();
                        op9.Questao9();
                        break;
                    case 10:
                        Exercicios op10 = new Exercicios();
                        op10.Questao10();
                        break;
                    case 11:
                        Exercicios op11 = new Exercicios();
                        op11.Questao11();
                        break;
                    case 12:
                        Exercicios op12 = new Exercicios();
                        op12.Questao12();
                        break;
                    case 0:
                        Console.WriteLine("Sair!");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");

                        break;





















                }






            } while (escolha!=0);

           

        }
    }
}
