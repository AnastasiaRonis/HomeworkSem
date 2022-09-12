// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Здравствуйте! Я могу назвать сумму цифр в вашем числе.");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Number(sum);

void Number(int sum)
{
    while(num>0)
    {
        sum=sum+num%10;
        num=num/10;       
    }
    Console.WriteLine(sum);
    Console.ReadKey();
}

