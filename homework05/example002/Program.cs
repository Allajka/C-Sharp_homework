/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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

void unevenPosition (int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
            if(i % 2 != 0) sum += arr[i];
    }
    Console.WriteLine($"Сумма чисел массива стоящих на нечетной позиции равна: {sum}");
}

int[] numbers = createArray(lengthArray: 10, minNumber: 0, maxNumber: 10);
printArray(numbers);
unevenPosition (numbers);