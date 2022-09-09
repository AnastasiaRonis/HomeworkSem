// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int Prompt(string message)
{
Console.Write(message);
string value = Console.ReadLine();
return Convert.ToInt32(value);
}

int Sqr(int n)
{
  return n*n;
}

int[] InputCoords(int n)
{
    int[] coord=new int[3];
    coord[0]=Prompt($"Введите x {n} точки: ");
    coord[1]=Prompt($"Введите y {n} точки: ");
    coord[2]=Prompt($"Введите z {n} точки: ");
    return coord;
}

int[] coord1=InputCoords(1);
int[] coord2=InputCoords(2);
int[] coord3=InputCoords(3);

double result = Math.Sqrt(Sqr(coord2[0]-coord1[0]) + 
                Sqr(coord2[1]-coord1[1]) + 
                Sqr(coord2[2]-coord1[2]));
Console.WriteLine(result);


// void Coords(string[] args)
// {
//     Console.Write("Введите X1: ");
//     double X1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите Y1: ");
//     double Y1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите X2: ");
//     double Z1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите Y2: ");
//     double X2 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите Y2: ");
//     double Y2 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите Y2: ");
//     double Z2 = Convert.ToDouble(Console.ReadLine());
//     double S = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) +
//             Math.Pow(Z2 - Z1, 2));
//     Console.WriteLine("S = {0}", S);
//     Console.ReadLine();
// }
// Coords(args);


