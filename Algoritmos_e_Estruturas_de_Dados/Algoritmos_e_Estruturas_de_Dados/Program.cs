using Algoritmos_e_Estruturas_de_Dados;
using Algoritmos_e_Estruturas_de_Dados.ProfessorMario;
using System.Globalization;

//Capitulo_1.OrdemNaoDecrecente(new List<int>{ 1, 2, 51, 2, 19, 20, 6});
//int[] vetorA =  new int[5] {2,94, 2, 5,6};
//int[] vetorB = new int[8] {1,5,23,6,7,9,43,81};

//bool repetidos = Aula01_2.VerificaRepeticao(vetorB);

//Console.WriteLine(repetidos);

//Console.WriteLine(String.Join(", ", vetorB));

//Console.WriteLine("Ordenando por inserção: ");
//Console.WriteLine(String.Join(", ", Capitulo_1.Insercao(ref vetorB)));
//Console.WriteLine(new string('=', 50));
//Console.WriteLine(String.Join(", ", vetorA));
//Console.WriteLine("Ordenando por inserção: ");
//Console.WriteLine(String.Join(", ", Capitulo_1.Insercao(ref vetorA)));

//Console.WriteLine(Aula01_2.lgProd(8));
/*
Stack<int> A = new Stack<int>();
Stack<int> B = new Stack<int>();
Stack<int> C = new Stack<int>();

A = Aula02.CriaPilhaComNDiscos(7);
Console.Write("A: ");
Console.WriteLine(string.Join(", ", A));


Console.Write("C: ");
Console.WriteLine(string.Join(", ", C));

Console.WriteLine("Chama a função Hanoi();");
Aula02.Hanoi(7, A, B , C);

Console.Write("A: ");
Console.WriteLine(string.Join(", ", A));


Console.Write("C: ");
Console.WriteLine(string.Join(", ", C));
*/

double iterativo = Aula03.e_iterativo(3,3);
double recursivo = Aula03.e_recursivo(3,3);
double recursivo2 = Aula03_2.ex2(3, 3);

Console.WriteLine($"Iterativo: {iterativo}\nRecursivo: {recursivo}\nRecursivo 2: {recursivo2}");