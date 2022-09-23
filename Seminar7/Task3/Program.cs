// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[, ]{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
FillArray(array);
System.Console.WriteLine();
PrintArray(array);

void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
    int sredarifmet = 0;
    int sum = 0;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(0,10);
            sum += array[i, j];
            sredarifmet = sum / (rows*columns);
               Console.WriteLine(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("Среднее арифметическое = " + sredarifmet);
}

