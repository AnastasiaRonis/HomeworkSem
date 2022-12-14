// Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Номер строки с наименьшей суммой элементов: 1 строка
// (допускается указывать индекс строки в массиве, в данном примере - 0)

int[,] array = new int[, ]{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7},
};
FillArray(array);
System.Console.WriteLine();
PrintArray(array);

void FillArray(int[,] array)
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
    int sum = 0;
    int sumrow1 = 0;    
    int row = 0;
    
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        int sumrow2 = 1;
        for(int j = 0; j < array.GetLength(1)-1; j++) 
        {   
            sumrow2 += array[i, j];  
        } 
        if(sumrow2 < sumrow1)
            {   
                sum = sumrow2; 
                row = i-2;    
            }
                sumrow1 = sumrow2;
    }
    Console.WriteLine("\n\t Наименьшаяя сумма = {0}", sum);
    Console.WriteLine("\n\t Номер строки = {0}", row); 
    Console.ReadKey();
}


