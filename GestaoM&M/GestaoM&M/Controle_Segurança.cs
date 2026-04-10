/*
 * alunos: Mateus Vilaça & Matheus_Vinicus
 * Date: 18/03/2026
 * Time: 10:41
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoIndustrial
{
    public class C_Seguranca
    {
        public static void Acima_Media()
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
            double soma = 0;

            foreach (C_Operacao C_O in C_Operacao.Operacao)
            {
                soma += C_O.Dados_Sensor;
            }

            double media = soma / C_Operacao.Operacao.Count;

            int contador = 0;
            Console.WriteLine("=====|Leituras Acima da Média|=====\n");
            Console.WriteLine($"Média calculada: {media:F2}\n");
            foreach (C_Operacao C_O in C_Operacao.Operacao)
            {
                if (C_O.Dados_Sensor > media)
                {
                    Console.WriteLine($"Transformador: {C_O.Nome_Maquina}");
                    Console.WriteLine($"Leitura do sensor: {C_O.Dados_Sensor}");
                    Console.WriteLine("-----------------------------");
                    contador++;
                }
            }
            Console.WriteLine($"Quantidade de leituras acima da média: {contador}");
            Console.WriteLine("\nPressione algo para voltar...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Acima_85()
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

            double Valor_Base = 85;
            int contador = 0;
            foreach (C_Operacao C_O in C_Operacao.Operacao)
            {
                if (C_O.Dados_Sensor > Valor_Base)
                {
                    Console.WriteLine($"Transformador: {C_O.Nome_Maquina}");
                    Console.WriteLine($"Leitura do sensor: {C_O.Dados_Sensor}°C");
                    Console.WriteLine("-----------------------------");
                    contador++;
                }
            }
            Console.WriteLine($"Quantidade de leituras acima de 85°C: {contador}");
            Console.WriteLine("\nPressione algo para voltar...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Relatorio_Insp()
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

            double Valor_Limite = 85.00;
            int contador = 0;

            foreach (C_Operacao C_O in C_Operacao.Operacao)
            {
                if (C_O.Dados_Sensor < Valor_Limite)
                {
                    Console.WriteLine("=====|Transformadores APROVADOS para próxima etapa|=====\n");
                    Console.WriteLine($"Transformador: {C_O.Nome_Maquina}");
                    Console.WriteLine($"Leitura do sensor: {C_O.Dados_Sensor:F2}°C");
                    Console.WriteLine("-----------------------------");
                    contador++;
                }
                else
                {
                    Console.WriteLine("=====|Transformadores Para INSPEÇÃO|=====\n");
                    Console.WriteLine($"Transformador: {C_O.Nome_Maquina}");
                    Console.WriteLine($"Leitura do sensor: {C_O.Dados_Sensor:F2}°C");
                    Console.WriteLine("-----------------------------");
                }
            }
            Console.WriteLine("\nPressione algo para voltar...");
            Console.ReadKey();
            Console.Clear();
        }

    }
    
}
