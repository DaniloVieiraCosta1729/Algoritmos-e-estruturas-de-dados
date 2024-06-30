using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_e_Estruturas_de_Dados.ProfessorMario
{
    public class Aula01_2
    {
        public static bool VerificaRepeticao(int[] vetorA)
        {
            bool resultado = false;

            for (int i = 0; i < vetorA.Length; i++)
            {
                for (int j = i+1; j < vetorA.Length; j++)
                {
                    resultado = (vetorA[i] == vetorA[j]) ? true : false;

                    if (resultado == true)
                    {
                        return resultado;
                    }
                }
            }
            return resultado;
        }

        // Errei ao marcar a classe como Aula01_2, teria sido melhor chamar de Aula01

        public static int lgProd(int n)
        {
            int x = 0;

            int prod = 1;

            do
            {
                x++;
                prod = (int)Math.Floor(Math.Pow(2, x));
            } while (prod <= n); // uma forma melhor para a condição é prod <= n/2, pois se 2^x = n/2 ele executa mais uma vez e dá exatamente n; se 2^x < n/2, mas 2^(x+1) > n/2, então ele vai chegar no piso de lg(n).

            return x-1;
        }
    }
}
