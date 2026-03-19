/*
 * alunos: Mateus Vilaça & Matheus_Vinicus
 * Date: 18/03/2026
 * Time: 10:41
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GestaoIndustrial
{
    public class Controle_Org
    {
        public static void Ord_Cre()
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

            var crescente = C_Operacao.Operacao
            .OrderBy(o => o.Dados_Sensor)
            .ToList();
            Console.WriteLine("=====|Ordem Crescente|=====");
            foreach (var item in crescente)
            {
                Console.WriteLine($"{item.Nome_Maquina} - {item.Dados_Sensor}°C");
                Console.WriteLine("---------------------------");
            }
        }

        public static void Ord_Dec()
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
            var decrescente = C_Operacao.Operacao
            .OrderByDescending(o => o.Dados_Sensor)
            .ToList();
            Console.WriteLine("=====|Ordem Decrescente|=====");
            foreach (var item in decrescente)
            {
                Console.WriteLine($"{item.Nome_Maquina} - {item.Dados_Sensor}°C");
                Console.WriteLine("---------------------------");
            }


        }

        public static void Tres_Maiores_Temp()
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
            var decrescente = C_Operacao.Operacao
            .OrderByDescending(o => o.Dados_Sensor)
            .ToList();
            
            Console.WriteLine("=====|TOP 3 MAIORES|=====");
            
            var top3 = decrescente.Take(3);

            foreach (var item in top3)
            {
                Console.WriteLine($"{item.Nome_Maquina} - {item.Dados_Sensor}°C");
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine("\nPressione algo para voltar...");
            Console.ReadKey();
            Console.Clear();


        }
    }
}
