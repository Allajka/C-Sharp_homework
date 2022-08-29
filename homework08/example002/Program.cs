/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] CreateArrayRandomNumbers(int row, int col)
{
    int[,] numbers = new int[row, col];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
    return numbers;
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
int SumRow(int[,] arr, int row)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        sum += arr[row, i];
    }
    return sum;
}
void ItemRow(int[,] arr)
{
    for (int i = 0; i < 1; i++)
    {
        int minSumRow = SumRow(arr, row: i);
        int itemRow = i;
        for (int j = 1; j < arr.GetLength(0); j++)
        {
            int sumRow = SumRow(arr, row: j);
            if (sumRow < Convert.ToInt32(minSumRow))
            {
                minSumRow = sumRow;
                itemRow = j;
            }
        }
        Console.WriteLine($"Номер строки - {itemRow + 1} с наименьшей суммой элементов - {minSumRow}.");
    }
}

int[,] numbers = CreateArrayRandomNumbers(row: 5, col: 8);
PrintArray(numbers);
Console.WriteLine();
ItemRow(numbers);
