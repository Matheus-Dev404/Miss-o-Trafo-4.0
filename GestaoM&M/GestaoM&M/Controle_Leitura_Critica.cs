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
    public class Controle_L_Critica
    {
        public static void Pesquisa_Temperatuda()
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

            double Temperatura_Pesquisa = 0;

            Console.WriteLine("Digite a temperatura para pesquisa:");
            while (!double.TryParse(Console.ReadLine(), out Temperatura_Pesquisa))
            {
                Console.WriteLine("[Erro!] Digite um número para pesquisa!");
            }
            bool Encontrou = false;
            Console.WriteLine("\n=====|Resultado da Pesquisa|=====\n");

            for (int i = 0; i < C_Operacao.Operacao.Count; i++)
            {
                C_Operacao item = C_Operacao.Operacao[i];

                if (item.Dados_Sensor == Temperatura_Pesquisa)
                {
                    Encontrou = true;

                    Console.WriteLine($"Temperatura encontrada na posição: {i}");
                    Console.WriteLine($"Transformador: {item.Nome_Maquina}");
                    Console.WriteLine($"Leitura do sensor:{item.Dados_Sensor}°C");
                }
            }
            if (!Encontrou)
            {
                Console.WriteLine("Temperatura não encontrada.");
            }
            Console.WriteLine("\nPressione algo para voltar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
