/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] CreateArray(int row, int col)
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

double AverageNumbersCol(int[,] arr, int col)
{
    double result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        result += arr[i, col];
    }
    return result / arr.GetLength(1);
}

void PrintAverageNumbersCol(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        double average = AverageNumbersCol(numbers, i);
        Console.WriteLine($"Cреднее арифметическое столбца № {i + 1} = {average}.");
    }
}

int[,] numbers = CreateArray(5, 5);
PrintArray(numbers);
PrintAverageNumbersCol(numbers);