// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


System.Console.WriteLine("    " + "Программа вычисления функции Аккермана с помощью рекурсии");
System.Console.WriteLine();
int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");
System.Console.WriteLine(Akkerman(m, n));

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
