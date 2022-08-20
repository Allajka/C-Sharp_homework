/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] creatArray(int quantity)
{
    int[] array = new int[quantity];
    for (int i = 0; i < quantity; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}
Console.Write("Введите желаемое количество элементов в массиве: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int[] numbers = creatArray(quantity);
printArray(numbers);
