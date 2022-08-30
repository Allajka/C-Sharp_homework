/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
например, на выходе получится вот такой массив
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
        Console.WriteLine();
    }
}
int[,] arr = new int[4, 4];
int value = 1;

for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        arr[i, j] = value;
        value++;
    }
}
for (int i = 1; i < arr.GetLength(0); i++)
{
    arr[i, arr.GetLength(0) - 1] = value;
    value++;
}
for (int i = arr.GetLength(0) - 1; i >= 0; i--)
{
    arr[arr.GetLength(0) - 1, i] = value;
    value++;
}
for (int i = 2; i > 0; i--)
{
    arr[i, 0] = value;
    value++;
}
for (int i = 1; i < arr.GetLength(0) - 2; i++)
{
    for (int j = 1; j < arr.GetLength(0) - 1; j++)
    {
        arr[i, j] = value;
        value++;
    }
}
for (int i = 2; i < arr.GetLength(0)-1; i++)
{
    for (int j = 2; j > 0; j--)
    {
        arr[i, j] = value;
        value++;
    }
}
PrintArray(arr);
