/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],3} ");
        }
        System.Console.WriteLine();
    }
}

int[,] CreateArray(int row, int col)
{
    int[,] number = new int[row, col];
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = new Random().Next(0, 10);
        }
    }
    return number;
}

void SearchArrayNumber(int[,] arr, int desiredNumber)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == desiredNumber)
            {
                Console.WriteLine($"Число: {desiredNumber} присутствует в массиве, позиция [{i}, {j}]");
                count += 1;
            }
        }
    }
    if (count == 0) Console.WriteLine($"Число: {desiredNumber} отсутствует в массиве");
}

int[,] numbers = CreateArray(5, 5);
Console.Write("Введите число для поиска: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
PrintArray(numbers);
Console.WriteLine();
SearchArrayNumber(numbers, userNumber);
