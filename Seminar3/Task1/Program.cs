// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int i, x = 0;
int secnum = 0;
Console.WriteLine("Введите число: ");
int pol = Convert.ToInt32((Console.ReadLine()));
for(i = pol; i > 0; i = (i / 10))
{
    x = i % 10;
    Console.Write(x);
    secnum = x;
}

if(secnum == pol)
{
    Console.WriteLine("Да, это палиндром");
}
else
{
Console.WriteLine("Нет, это не палиндром");
}
Console.WriteLine(pol);
Console.WriteLine(secnum);
Console.ReadKey();





// // Console.WriteLine("Введите число: ");
// // int Number = Convert.ToInt32(Console.ReadLine()); 

// bool Palindrome(string x)
// {
//     for(int i = 0; i < x.Length / 2; i++)
//     {
//         if (x[i] != x[x.Length - 1 - i])
//         return false;
//     }
//     return true;
// }

// if(x = Palindrome)
// {
//     Console.WriteLine("Да, это палиндром");
// }
// else
// {
// Console.WriteLine("Нет, это не палиндром");
// }
// Console.WriteLine(x);
// Console.WriteLine(Palindrome);
// Console.ReadKey();



// // int Prompt(string message)
// // {
// // Console.Write(message);
// // string value = Console.ReadLine();
// // return Convert.ToInt32(value);
// // }
// // int Polindrom=Prompt("Введите пятизначное число: ");

// // // bool NumPolindrom(int num)
// // // {
// // //    int length = num.Length();
// // //     for(int i=0; i<length/2; i++)
// // //     {
// // //         if(num[i]=num[length-i-1])
// // //         {
// // //             Console.WriteLine("Нет, это не палиндром");
// // //             return false;
// // //         }
// // //     }
// // //     Console.WriteLine("Да, это палиндром");
// // //     return true;
// // // }



// // bool Polindrom(string num)
// // {
// //     int length = num.Length();
// //     for(int i=0; i<length/2; i++)
// //     {
// //         if(num[i]=num[length-i-1])
// //         {
// //             return false;
// //         }
// //     }
// //     return true;
// // }
// // if(num == Polindrom)
// // {
// //     Console.WriteLine("Да, это палиндром");
// // }
// // else
// // {
// // Console.WriteLine("Нет, это не палиндром");
// // }
// // Console.WriteLine(num);
// // Console.WriteLine(Polindrom);
// // Console.ReadKey();