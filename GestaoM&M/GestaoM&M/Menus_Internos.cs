/*
 * alunos: Mateus Vilaça & Matheus_Vinicus
 * Date: 18/03/2026
 * Time: 10:41
 * 
 */
using System;

namespace GestaoIndustrial
{
    /// <summary>
    /// Description of Class2.
    /// </summary>
    public class Menus_Internos
    {

        public static void Menu_C_O() //Menu do Controle de operação
        {
            bool menu = true;// variavel para manter o funcionamento do menu até que o usuário 
            //Variavel para tratamento de erro caso o usuario digite algo diferente de numero 
           //variavel para definir o menu

            while (menu)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("=====|Bem Vindo ao Sistema de Controle De Operação|=====");
                Console.WriteLine("==================|Escolha uma opção:|==================");
                Console.WriteLine("1. Armazenar dados dos sensores" + "\n2. Exibir temperatura dos sensores" + "\n3. Cálculo de média" + "\n4. Verificar maior e menor temperatura " + "\n0. Sair");

                Console.WriteLine("Digite uma opção:");
                char escolha = Console.ReadKey(true).KeyChar;//variavel para definir o menu
                if (!char.IsDigit(escolha))
                {
                    Console.WriteLine("\nDigite apenas números!");
                    Console.ReadKey();
                    continue;
                }
                switch (escolha)
                    {
                        case '1':
                            Console.Clear();
                            C_Operacao.AdicaoSensor();
                            break;
                        case '2':
                            Console.Clear();
                            C_Operacao.Exibir_Dados();
                            break;
                        case '3':
                            Console.Clear();
                            C_Operacao.Calculo_Media();
                            break;
                        case '4':
                            Console.Clear();
                            C_Operacao.Maior_Menor_Temperatura();
                            break;
                        case '0':
                            menu = false;
                            break;
                        default:
                        Console.WriteLine("\nOpção inválida! \nDigite algo para tentar novamente...");
                        Console.ReadKey();
                            break;
                    }


            }
        }
        public static void Menu_C_S() //Menu do Controle de segurança
        {
            bool menu = true;// variavel para manter o funcionamento do menu até que o usuário 
            

            while (menu)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=====|Bem Vindo ao Sistema de Controle De Operação|=====");
                Console.WriteLine("==================|Escolha uma opção:|==================");
                Console.WriteLine("1. Quantidade de leituras acima da média" + "\n2. Quantidade de leituras que ultrapassaram 85°C;" + "\n3. Relatório Transformadores" + "\n0. Sair");

                Console.WriteLine("Digite uma opção:");
                char escolha = Console.ReadKey(true).KeyChar;//variavel para definir o menu
                if (!char.IsDigit(escolha))
                {
                    Console.WriteLine("\nDigite apenas números!");
                    Console.ReadKey();
                    continue;
                }
                switch (escolha)
                    {
                        case '1':
                            Console.Clear();
                            C_Seguranca.Acima_Media();
                            break;
                        case '2':
                            Console.Clear();
                            C_Seguranca.Acima_85();
                            break;
                        case '3':
                            Console.Clear();
                            C_Seguranca.Relatorio_Insp();
                             break;
                        case '0':
                            menu = false;
                            break;
                    default:
                        Console.WriteLine("\nOpção inválida! \nDigite algo para tentar novamente...");
                        Console.ReadKey();
                        break;
                }

                

            }
        }


        public static void Menu_C_C() //Menu do Controle de leitura crítica
        {
            bool menu = true;// variavel para manter o funcionamento do menu até que o usuário 
           

            while (menu)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=====|Bem Vindo ao Sistema de Controle De Operação|=====");
                Console.WriteLine("==================|Escolha uma opção:|==================");
                Console.WriteLine("1. Pesquisa de Temperatura" + "\n0. Sair");

                Console.WriteLine("Digite uma opção:");
                char escolha = Console.ReadKey(true).KeyChar;//variavel para definir o menu
                if (!char.IsDigit(escolha))
                {
                    Console.WriteLine("\nDigite apenas números!");
                    Console.ReadKey();
                    continue;
                }
                switch (escolha)
                    {
                        case '1':
                            Console.Clear();
                            Controle_L_Critica.Pesquisa_Temperatuda();
                            break;
                        case '0':
                            menu = false;
                            break;
                        default:
                        Console.WriteLine("\nOpção inválida! \nDigite algo para tentar novamente...");
                        Console.ReadKey();
                            break;
                    }

                

            }
        }


        public static void Menu_C_ORG() //Menu do Controle de leitura crítica
        {
            bool menu = true;// variavel para manter o funcionamento do menu até que o usuário 
           

            while (menu)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("=====|Bem Vindo ao Sistema de Controle De Operação|=====");
                Console.WriteLine("==================|Escolha uma opção:|==================");
                Console.WriteLine("1. Leitura sensores em ordem crescente" + "\n2. Leitura sensores em ordem decrescente" + "\n3. Top 3 maiores leituras" + "\n0. Sair");

                Console.WriteLine("Digite uma opção:");
                char escolha = Console.ReadKey(true).KeyChar;//variavel para definir o menu
                if (!char.IsDigit(escolha))
                {
                    Console.WriteLine("\nDigite apenas números!");
                    Console.ReadKey();
                    continue;
                }
                switch (escolha)
                    {
                        case '1':
                            Console.Clear();
                            Controle_Org.Ord_Cre();
                            break;
                        case '2':
                            Controle_Org.Ord_Dec();
                            break;
                        case '3':
                            Controle_Org.Tres_Maiores_Temp();
                            break;
                        case '0':
                            menu = false;
                            break;
                        default:
                        Console.WriteLine("\nOpção inválida! \nDigite algo para tentar novamente...");
                        Console.ReadKey();
                            break;
                    }

                

            }
        }


    }
}
