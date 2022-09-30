// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine("Программа, которая выводит все натуральные числа от N до 1");
System.Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(NaturalNumbers(N));

string NaturalNumbers(int N)
{
    if (N == 1)
        return N.ToString();
    return N.ToString() + NaturalNumbers(N - 1);
}