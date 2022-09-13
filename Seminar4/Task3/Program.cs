// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Здравствуйте! Я задаю массив.");
int size = 8;
int[] array = new int [size];
FillArray(array);
Console.WriteLine("{0}", string.Join(", ", array));
// PrintArray(array);

void FillArray(int[] array)
{
    Console.WriteLine("Введите строку: ");
    for(int i=0; i<array.Length; i++)
    {
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0; i<array.Length; i++)
    Console.WriteLine(array[i]);
}
