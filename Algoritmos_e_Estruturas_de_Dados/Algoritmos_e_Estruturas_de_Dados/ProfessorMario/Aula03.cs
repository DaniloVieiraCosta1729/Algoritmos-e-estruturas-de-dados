using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_e_Estruturas_de_Dados.ProfessorMario
{
    public class Aula03
    {
        // Função exponêncial -  e: R x N -> R, (x, n) |-> x ^ n

        // De uma forma iterativa: 
        public static double e_iterativo(double x, int n)
        {
            double resultado = 1;

            for (int i = 0; i < n; i++)
            {
                resultado *= x;
            }
            return resultado;
        }
        // Tem complexidade O(n), pois a quantidade de iterações é proporcional a entrada n.
        // Quanto a memória, ele tbm é bem eficiente, pois usa apenas 2 variáveis além daquilo que foi passado nos parâmetros e vai atualizando o valor de resultado. Então eu diria que ele usa uma quantidade constante de memória.

        // De uma forma recursiva:
        public static double e_recursivo(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return x * e_recursivo(x, n-1);
        }
        // Tem complexidade O(n)
        // Quanto a memória, ele é menos eficiente do que o iterativo, pois precisa armazenar os resultados de cada etapa da recursão em uma stack, usando uma quantidade proporcional a n de espaços da memória.
    }
}
