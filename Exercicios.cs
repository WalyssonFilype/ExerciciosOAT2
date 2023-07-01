using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOAT2.cs
{
    internal class Exercicios
    {
        public void Questao1()
        {
            int A = 0;
            int B = 0;
            int C = 0;
            int valor = 0;
            Console.WriteLine("Informe o valor de A:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C:");
            C = int.Parse(Console.ReadLine());
            valor = A + B;
            Console.WriteLine("A soma é:" + valor);
            if (valor < C)
            {
                Console.WriteLine("o resultado da soma de A e B é menor que o valor de C:");
            }
            else
                Console.WriteLine("o resultado da soma de A + B é maior ou igual ao valor de C:");
            Console.WriteLine();

        }
        public void Questao2()
        {

            int tempo;
            string nome, sexo, civil;

            Console.WriteLine("Infome seu nome completo:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe seu sexo: (F ou M)");
            sexo = Console.ReadLine();
            Console.WriteLine("Informe seu estado civil ( Solteiro(a), Casado(a), Viuvo(a) )");
            civil = Console.ReadLine();
            Console.WriteLine();

            if (sexo == "F" && civil == "casada")
            {
                Console.WriteLine("Quanto tempo de casada?");
                tempo = int.Parse(Console.ReadLine());
                Console.WriteLine("Dados do Pessoais: ");
                Console.WriteLine();
                if (sexo == "F")
                {
                    sexo = "Mulher";
                }
                else
                    sexo = "Homem";
                Console.WriteLine("*" + nome);
                Console.WriteLine("*" + sexo);
                Console.WriteLine("*Casada há " + tempo);
                Console.ReadLine();
            }
            else
                Console.WriteLine("Dados do Pessoais: ");
            {
                if (sexo == "F")
                {
                    sexo = "Mulher";
                }
                else
                    sexo = "Homem";
                Console.WriteLine("*" + nome);
                Console.WriteLine("*" + sexo);
                Console.WriteLine("*" + civil);
            }


        }


    
        public void Questao3()
        {
            int num;
            Console.WriteLine("Informe um numero:");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("O numero " + num + " é par");
            else
                Console.WriteLine("O numero " + num + " é impar");
            Console.ReadKey();

        }
        public void Questao4()
        {
            int A;
            int B;
            int C;
            Console.WriteLine("Informe o valor de A:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B:");
            B = int.Parse(Console.ReadLine());
            if (A == B)
            {
                C = A + B;
                Console.WriteLine("O resultado é:" + C + " ");
            }
            else
                C = A * B;
            Console.WriteLine("O resultado é:" + C + " ");
            Console.ReadLine();

        }
        public void Questao5()
        {
            int num1;
            int resultado;
            Console.WriteLine("Informe um numero positivo ou negativo");
            num1 = int.Parse(Console.ReadLine());
            if (num1 < 0)
            {
                resultado = num1 * 2;
                Console.WriteLine(" O resultado é:" + resultado);
            }
            else
                resultado = num1 * 3;
            Console.WriteLine(" O resultado é:" + resultado);
            Console.ReadKey();

        }
        public void Questao6()
        {
            bool valor1;
            bool valor2;
            Console.Write("informe o primeiro valor booleano(true ou false):");
            valor1 = bool.Parse(Console.ReadLine());
            Console.Write("informe o segundo valor booleano(true ou false):");
            valor2 = bool.Parse(Console.ReadLine());
            if (valor1 == true && valor2 == true)
            {
                Console.Write("Ambos os valores são verdadeiros");
            }
            else if (valor1 == false && valor2 == false)
            {
                Console.Write("Ambos os valores são falsos");
            }
            else if (valor1 == false && valor2 == true)
            {
                Console.Write("O valor 1 é falso e o valor 2 verdadeiro.");
            }
            else
                Console.Write("O valor 1 é verdadeiro e o valor 2 é falso.");

        }
        public void Questao7()
        {
            int num;
            Console.WriteLine("digite um número:");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                int num1 = num + 5;
                Console.WriteLine("O resultado é:" + num1);
            }
            else
            {
                int num1 = num + 8;
                Console.WriteLine("O resultado é:" + num1);
            }
            Console.ReadKey();

        }
        public void Questao8()
        {
            int[] valores = new int[3];
            int i = 1;
            for (i = 1; i < 4; i++)
            {
                Console.Write("Infome o " + i + "º valor:  ");
                valores[i] = int.Parse(Console.ReadLine());
                if (i == 2)
                {
                    if (valores[2] == valores[1])
                    {
                        Console.Write("Informe um valor diferente ao anterior: ");
                        valores[2] = int.Parse(Console.ReadLine());
                    }
                }
                if (i == 3)
                {
                    if (valores[3] == valores[1] || valores[3] == valores[2])
                    {
                        Console.Write("Informe um valor diferente dos anteriores: ");
                        valores[3] = int.Parse(Console.ReadLine());
                    }
                }
            }

        }
        public void Questao9()
        {
            string sexo = string.Empty;
            decimal pesoIdeal = 0;
            Console.WriteLine("Informe seu sexo: F (femenino) e M (masculino)");
            sexo = Console.ReadLine().ToUpper();
            if (sexo != "F" && sexo != "M")
            {
                Console.WriteLine("Informe novamente");
                sexo = Console.ReadLine().ToUpper();
            }
            if (sexo == "M")
            {
                Console.WriteLine("Infome sua altura:");
                decimal h = decimal.Parse(Console.ReadLine());
                pesoIdeal = (decimal.Parse("72,7") * h) - 58;
            }
            else
            {
                Console.WriteLine("Informe sua altura:");
                decimal h = decimal.Parse(Console.ReadLine());
                pesoIdeal = (decimal.Parse("62,1") * h) - decimal.Parse("44,7");
            }
            Console.WriteLine($"Seu peso ideal é:{pesoIdeal}");
            Console.ReadKey();

            decimal IMC = 0;
            decimal peso = 0;
            decimal altura = 0;
            Console.WriteLine("Informe seu peso");
            peso = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura");
            altura = decimal.Parse(Console.ReadLine());
            IMC = (peso / (altura + altura));
            Console.WriteLine("Seu IMC é:{0}", IMC);
            if (IMC < decimal.Parse("18,5"))
                Console.WriteLine("Você está abaixo do peso");
            else if (IMC >= decimal.Parse("18,5") && IMC < 25)
                Console.WriteLine("Seu peso normal");
            else if (IMC >= 25 && IMC < 30)
                Console.WriteLine("Você está acima do peso");
            else
                Console.WriteLine("Você está obeso(a)");
            Console.WriteLine();

        }
        public void Questao10()
        {
            decimal IMC = 0;
            decimal peso = 0;
            decimal altura = 0;
            Console.WriteLine("Informe seu peso");
            peso = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura");
            altura = decimal.Parse(Console.ReadLine());
            IMC = (peso / (altura + altura));
            Console.WriteLine("Seu IMC é:{0}", IMC);
            if (IMC < decimal.Parse("18,5"))
                Console.WriteLine("Você está abaixo do peso");
            else if (IMC >= decimal.Parse("18,5") && IMC < 25)
                Console.WriteLine("Seu peso normal");
            else if (IMC >= 25 && IMC < 30)
                Console.WriteLine("Você está acima do peso");
            else
                Console.WriteLine("Você está obeso(a)");
            Console.WriteLine();

        }
        public void Questao11()
        {
            int escolha;
            double desconto = 0;
            double valor = 0;
            double juros = 0;
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("     Iphone 14 Pro Max");
                Console.WriteLine("     Valor: R$ 7.500,00");
                Console.WriteLine("    Formas de pagamento:");
                Console.WriteLine();
                Console.WriteLine("1. A vista no dinheiro ou cheque.");
                Console.WriteLine("2. À vista no cartão de crédito.");
                Console.WriteLine("3. Parcelado duas vezes sem juros.");
                Console.WriteLine("4. Parcelado quatro vezes com juros.");
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)

                    {
                        case 1:
                            valor = 10.0 / 100 * 7500;
                            desconto = 7500 - valor;
                            Console.WriteLine("Pagamento à vista com 10% de desconto, R$ " + valor + ", com o valor final de R$ " + desconto + ".");
                            break;
                        case 2:
                            valor = 15.0 / 100 * 7500;
                            desconto = 7500 - valor;
                            Console.WriteLine("Pagamento à vista no cartão de crédito com 15% de desconto, R$ " + valor + ", com o valor final de R$ " + desconto + ".");
                            break;
                        case 3:
                            int parcela = 7500 / 2;
                            Console.WriteLine("Pagamento parcelado em duas vezes sem juroes e sem desconto, 2 de R$" + parcela + " cada.");
                            break;
                        case 4:
                            valor = ((10.0 / 100) * 7500) + 7500;
                            juros = valor / 4;
                            Console.WriteLine($"Pagamento parcelado em quatro vezes com juros de 10%, total de R$ " + valor + ", com o valor final de R$ " + juros + " cada.");
                            break;
                        default:
                            Console.WriteLine("Digite uma das opções acima!");
                            break;
                    }
                }
            } while (escolha != 4) ;
            Console.ReadLine();

        }
        public void Questao12()
        {
            Console.Write("Digite o número de identificação do aluno: ");
            int numeroIdentificacao = int.Parse(Console.ReadLine());

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a média dos exercícios: ");
            double mediaExercicios = double.Parse(Console.ReadLine());

            // Cálculo da média de aproveitamento
            double mediaAproveitamento = (nota1 + nota2 * 2 + nota3 * 3 + mediaExercicios) / 7;

            // Atribuição do conceito
            char conceito;
            if (mediaAproveitamento >= 90)
                conceito = 'A';
            else if (mediaAproveitamento >= 75)
                conceito = 'B';
            else if (mediaAproveitamento >= 60)
                conceito = 'C';
            else if (mediaAproveitamento >= 40)
                conceito = 'D';
            else
                conceito = 'E';

            // Verificação da aprovação
            string mensagemAprovacao = (conceito == 'A' || conceito == 'B' || conceito == 'C') ? "Aprovado" : "Reprovado";

            // Saída de dados
            Console.WriteLine("Número de identificação: " + numeroIdentificacao);
            Console.WriteLine("Notas: " + nota1 + ", " + nota2 + ", " + nota3);
            Console.WriteLine("Média dos exercícios: " + mediaExercicios);
            Console.WriteLine("Média de aproveitamento: " + mediaAproveitamento);
            Console.WriteLine("Conceito: " + conceito);
            Console.WriteLine("Situação: " + mensagemAprovacao);

        }









      }
}
