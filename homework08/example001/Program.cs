/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] CreateArrayRandomNumbers(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void SortArray(int[,] arr, int row)
{
    for (int i = 0; i <= arr.GetLength(0) - 1; i++)
    {
        int maxPos = i;
        for (int j = i + 1; j <= arr.GetLength(0) - 1; j++)
        {
            if (arr[row, j] > arr[row, maxPos]) maxPos = j;
        }
        int temporary = arr[row, i];
        arr[row, i] = arr[row, maxPos];
        arr[row, maxPos] = temporary;
    }
}

int[,] numbers = CreateArrayRandomNumbers(5, 5);
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    SortArray(numbers, i);
}

System.Console.WriteLine();
PrintArray(numbers);
