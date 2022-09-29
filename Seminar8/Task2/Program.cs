// Задача 2: Задайте две квадратные матрицы одного размера. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrixA = new int[, ]{
    {2, 4},
    {3, 2},
};
int[,] matrixB = new int[, ]{
    {2, 4},
    {3, 2},
};

FillMatrix(matrixA);
System.Console.WriteLine();
FullMatrix(matrixB);
System.Console.WriteLine();
MatrixMultiplication(matrixA, matrixB, matrixC);

void FillMatrix(int[,] matrixA)
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

void FullMatrix(int[,] matrixB)
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

void MatrixMultiplication(int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
  for (int i = 0; i < matrixC.GetLength(0); i++)
  {
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrixA.GetLength(1); k++)
      {
        sum += matrixA[i,k] * matrixB[k,j];
      }
      matrixC[i,j] = sum;
    }
    Console.Write(matrixC + " ");
  }
}

