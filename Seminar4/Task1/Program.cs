// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Здравствуйте! Я могу возвести число А в натуральную степень В.");

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
Number(A,B);

void Number (int A, int B)
{
    int index=1;
    while (index>0)
    {
        System.Console.WriteLine("A^B =" + Math.Pow(A,B));
        break;
    }
    Console.ReadKey();
}     

