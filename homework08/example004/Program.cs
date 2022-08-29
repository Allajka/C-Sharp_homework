/* ** Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] A =
{
    {2, 4},
    {3, 2},
};

int[,] B =
{
    {3, 4},
    {3, 3},
};

int[,] C = new int[2, 2];

for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        C[i,j] = A[i,i] * B[i,j] + A[i,A.GetLength(1) - 1] * B[A.GetLength(1) - 1, j];
    }
}

void printArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

printArray(C);