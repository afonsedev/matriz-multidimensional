using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace revisaoVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int numero_gerado_vendas = random.Next(100);


            Console.WriteLine("Número de vendas mensal");
            Console.WriteLine();

            string[,] matriz_nomes = new string[3, 3];

            matriz_nomes[0, 0] = "Natália";
            matriz_nomes[0, 1] = "Leonardo";
            matriz_nomes[0, 2] = "Sara";
            matriz_nomes[1, 0] = "João";
            matriz_nomes[1, 1] = "Camila";
            matriz_nomes[1, 2] = "Gustavo";
            matriz_nomes[2, 0] = "Tamires";
            matriz_nomes[2, 1] = "Moisés";
            matriz_nomes[2, 2] = "Fernanda";


            int[,] matriz_vendas_empregados = new int[3, 3]
            {
                {2, 54, 64 },
                {12, 423, 43},
                {45, 54, 23}
            };


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Funcionário: " + matriz_nomes[i, j] + " | Número de vendas mensal: " + matriz_vendas_empregados[i, j]);
                }
            }


            // cast<int>() transforma a matriz em uma sequência de int    
            int maior_venda = matriz_vendas_empregados.Cast<int>().Max();
            int menor_venda = matriz_vendas_empregados.Cast<int>().Min();

            Console.WriteLine();
            Console.WriteLine("Maior número de vendas: " + maior_venda);

            if (menor_venda < 5)
            {
                Console.WriteLine("Menor venda: " + menor_venda + " | Precisamos rever a estratégia de vendas");
            }

            Console.ReadKey();

        }
    }
}
