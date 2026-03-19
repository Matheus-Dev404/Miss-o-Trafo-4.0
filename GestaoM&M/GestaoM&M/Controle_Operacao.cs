/*
 * alunos: Mateus Vilaça & Matheus_Vinicus
 * Date: 18/03/2026
 * Time: 10:41
 * 
 */

using System;

namespace GestaoIndustrial
{
    public class C_Operacao //Cadastro e armazenamento de dados e transformador
    {


        public double Dados_Sensor { get; set; }
        public string Nome_Maquina { get; set; }

        public static List<C_Operacao> Operacao = new List<C_Operacao>();
        public static void AdicaoSensor()
        {
            string nome_maquina;
            double dados_sensor;
            string opcao;

            do
            {
                Console.Write("Digite o nome do transformador:");
                nome_maquina = Console.ReadLine();
                Console.WriteLine("Digite a medição do sensor");
                while (!double.TryParse(Console.ReadLine(), out dados_sensor))
                {
                    Console.WriteLine("[Erro!] Digite apenas números! Tente novamente.");
                }

                Operacao.Add(new C_Operacao { Nome_Maquina = nome_maquina, Dados_Sensor = dados_sensor });

                Console.WriteLine("\n[Sucesso!] Informações do transformador registrado!");
                do
                {
                    Console.WriteLine("\nDeseja cadastrar outro transformador? (S/N)");
                    opcao = Console.ReadLine().Trim().ToUpper();
                } while (opcao != "S" && opcao != "N");
            } while (opcao == "S");
        }

        public static void Exibir_Dados() //Impressao de nome e dados das máquinas
        {
            Console.Clear();
            if (C_Operacao.Operacao.Count == 0)
            {
                Console.WriteLine("Não há dados cadastrados");
                Console.WriteLine("Pressione alguma tecla para voltar...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            foreach (C_Operacao C_O in Operacao)
            {
                Console.WriteLine($"Transformador: {C_O.Nome_Maquina}");
                Console.WriteLine($"Sensor: {C_O.Dados_Sensor}");
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("Pressione algo para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Calculo_Media() //Impressao de média dos dados dos sensores
        {
            double soma = 0;

            double media = 0;
            foreach (C_Operacao C_O in Operacao)
            {
                soma += C_O.Dados_Sensor;
            }
            media = soma / Operacao.Count;
            Console.Clear();
            Console.WriteLine($"O resultado da média dos dados dos sensores é: {media}");
            Console.WriteLine("Pressione algo para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
        }


    public static void Maior_Menor_Temperatura() //Impressao de maior e menor temperatura e maquina atribuida
        {
            if (Operacao.Count > 0)
            {
                Console.WriteLine("Não há dados cadastrados");
            }
            else
            {
                C_Operacao maior = Operacao[0];
                C_Operacao menor = Operacao[0];
                foreach (C_Operacao C_O in Operacao)
                {
                    if (C_O.Dados_Sensor > maior.Dados_Sensor)
                    {
                        maior = C_O;
                    }
                    if (C_O.Dados_Sensor < maior.Dados_Sensor)
                    {
                        menor = C_O;
                    }
                }
                Console.WriteLine("===== RESULTADO =====\n");
                Console.WriteLine($"Maior temperatura:{maior.Dados_Sensor}°C");
                Console.WriteLine($"Transformador:{maior.Nome_Maquina}\n");

                Console.WriteLine($"Menor temperatura:{menor.Dados_Sensor}°C");
                Console.WriteLine($"Transformador: {menor.Nome_Maquina}\n");
            }
            Console.WriteLine("\nPressione algo para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }







    }
}
	
	
	
	

