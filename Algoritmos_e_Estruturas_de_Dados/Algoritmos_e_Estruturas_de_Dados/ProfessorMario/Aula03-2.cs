using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_e_Estruturas_de_Dados.ProfessorMario
{
    internal class Aula03_2
    {
        // Como acelerar ainda mais a versão recursiva da função exponencial?
        public static double ex2(double x, int n)
        {
            if (n == 0) { return 1; }

            double exp = ex2(x, n/2);
            exp *= exp;

            if (n % 2 == 0)
            {
                return exp;
            }

            return x * exp;
        }
    }
}
