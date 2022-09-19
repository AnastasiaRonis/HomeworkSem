// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int size = DataEntry("Введите числа ->");
int [] array = new int [size];
FillArray(array);
Console.WriteLine("[{0}]", string.Join(",", array));
PositiveNum(array);

int DataEntry(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray (int [] array)
{
    for(int i=0; i<array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
}

void PositiveNum (int[] array)
{
    int pol =0;
    for(int i=0; i<array.Length; i++)
    if (array[i] >= 0)
    pol++;
    Console.WriteLine(pol);
}