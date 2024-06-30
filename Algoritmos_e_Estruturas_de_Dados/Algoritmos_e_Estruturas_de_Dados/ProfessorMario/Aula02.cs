using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_e_Estruturas_de_Dados.ProfessorMario
{
    public class Aula02
    {
        // Recursão!

        // Problema (Torres de Hanoi): Temos três hastes, a saber, A, B e C. Se tivermos n discos empilhados na haste A de modo que nenhum disco maior fique sobre um menor e se não tivermos nenhum disco nas hastes B e C, então, crie um método que passe todos os discos de A para C de modo que cada disco seja movido sozinho e que nenhum disco nunca fique sobre um disco menor do ele próprio.

        // Podemos resolver esse problema recursivamente.

        /// <summary>
        /// Resolve a torre de Hanoi.
        /// </summary>
        /// <param name="qtdDiscos">Quantidade de discos à serem movidos de A para C.</param>
        /// <param name="A">Ponto de Partida.</param>
        /// <param name="B">Pilha Auxiliar</param>
        /// <param name="C">Ponto de Chegada.</param>
        public static void Hanoi(int qtdDiscos, Stack<int> A, Stack<int> B, Stack<int> C)
        {            
            if (qtdDiscos == 0)
            {
                return;
            }
            
            Hanoi(qtdDiscos - 1, A, C, B);
            if (A.Count != 0) { C.Push(A.Pop()); }
            Hanoi(qtdDiscos - 1, B, A, C);
        }

        public static Stack<int> CriaPilhaComNDiscos(int n)
        {
            Stack<int> pilhaDeTamanhoN = new Stack<int>();
            for (int i = 1; i <=n; i++)
            {
                pilhaDeTamanhoN.Push(i);
            }
            return pilhaDeTamanhoN;
        }
    }
}
