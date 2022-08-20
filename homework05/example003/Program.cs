/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] createArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
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

int[] numbers = createArray(length: 10, min: -100, max: 101);
printArray(numbers);


int  max = numbers[0];
int  min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max) max = numbers[i];
    if (numbers[i] < min) min = numbers[i];
}
int result =  max - min;
System.Console.WriteLine($"Разница max {max} и min {min}: {result} ");