/*
 * alunos: Mateus Vilaça & Matheus_Vinicus
 * Date: 18/03/2026
 * Time: 10:41
 * 
 */

using System;

namespace GestaoIndustrial
{
    public class MenuPrincipal
    {
        public static void Main()
        {
            bool menu =true;// variavel para manter o funcionamento do menu até que o usuário 
            

            while (menu)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("=====|Bem Vindo ao Sistema de Gestão Industrial|=====");
                Console.WriteLine("================|Escolha uma opção:|=================");
                Console.WriteLine("1. Controle de operação" + "\n2. Controle de segurança" + "\n3. Controle de leitura crítica" + "\n4. Controle organizacional de dados" + "\n0. Sair");

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
                            Menus_Internos.Menu_C_O();
                            break;
                        case '2':
                            Console.Clear();
                            Menus_Internos.Menu_C_S();
                            break;
                        case '3':
                            Console.Clear();
                            Menus_Internos.Menu_C_C();
                            break;
                        case '4':
                            Console.Clear();
                            Menus_Internos.Menu_C_ORG();
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