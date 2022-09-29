// Задача 2: Задайте две квадратные матрицы одного размера. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrixA = new int[,]{
    {2, 4},
    {3, 2},
};
int[,] matrixB = new int[,]{
    {3, 4},
    {3, 3},
};

FirstMatrix(matrixA);
Console.WriteLine();
SecondMatrix(matrixB);
Console.WriteLine();
PrintArray(matrixA, matrixB);
Console.WriteLine(MatrixMultiplication(matrixA, matrixB));

void FirstMatrix(int[,] matrixA)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            Console.Write(matrixA[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SecondMatrix(int[,] matrixB)
{
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            Console.Write(matrixB[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(0); j++)
        {
            for (int k = 0; k < matrixB.GetLength(1); k++)
            {
                matrixC[i, k] += matrixA[i, j] * matrixB[j, k];
            }
        }
    }
    return matrixC;
}

void PrintArray(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(0); j++)
        {
          Console.Write(matrixC[i, j] + " ");
        }
          Console.WriteLine();
    }
}

