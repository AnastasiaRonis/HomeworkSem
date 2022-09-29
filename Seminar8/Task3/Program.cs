// Задача 3. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел 
// (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

Console.WriteLine("\nВведите размер массива: ");
Console.Write("Количество столбцов: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество строк: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row, columns];
Console.WriteLine($"");

FillArray(array);
System.Console.WriteLine();
System.Console.WriteLine(Contains(array));

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 50);
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

bool Contains(int[,] array)
{
    System.Console.WriteLine("Введите value: ");
    int value = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == value)
            {
                return true;
            }
            return false;
        }
    }
    return false;
}
