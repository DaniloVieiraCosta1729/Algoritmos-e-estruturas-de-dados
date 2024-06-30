using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_e_Estruturas_de_Dados
{
    public class Capitulo_1
    {
        // ordenação de n inteiros em ordem não decrescente.

        /// <summary>
        /// Ordena uma LISTA de INTEIROS em ordem não decrescente.
        /// </summary>
        /// <param name="sequencia">Lista de inteiro (List<int>)</param>
        public static void OrdemNaoDecrecente(List<int> sequencia)
        {
            List<int> listaOrdenada = new List<int>();

            int menor = sequencia[0];

            while (sequencia.Count != 0)
            {
                menor = sequencia[0];
                foreach (int elemento in sequencia)
                {
                    menor = (menor > elemento) ? elemento : menor;
                }
                listaOrdenada.Add(menor);
                sequencia.Remove(menor);
            }

            Console.WriteLine(String.Join(", ", listaOrdenada));
        }

        // Ordenação por inserção

        public static int[] Insercao(ref int[] vetor)
        {
            for (int i = 1; i < vetor.Length; i++)
            {
                int chave = vetor[i];
                int j = i - 1;

                while (j >= 0 && vetor[j] > chave)
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }
                vetor[j+1] = chave;
            }

            return vetor;
        }
    }
}
