/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] createArray(int lengthArray, int minNumber, int maxNumber)
{
    int[] arr = new int[lengthArray];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minNumber, maxNumber);
    }
    return arr;
}

void printArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
    System.Console.WriteLine();
}

void evenNumber (int [] arr)
{
    Console.Write($"Четные цифры: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

void unevenNumber (int [] arr)
{
    Console.Write($"Нечетные цифры: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0) Console.Write(arr[i] + " ");
    }
}

int[] numbers = createArray(10, 100, 1000);
printArray(numbers);
evenNumber(numbers);
unevenNumber(numbers);
