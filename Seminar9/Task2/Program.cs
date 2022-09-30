// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Программа, которая находит сумму натуральных элементов от M до N");
System.Console.WriteLine();
System.Console.WriteLine("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumNaturalNumbers(M, N));

int SumNaturalNumbers(int M, int N)
{
    if (N == M)
        return M;
      return N + SumNaturalNumbers(M, N-1);
}
