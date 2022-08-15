/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
void printArray(int[] array, int quantity)
{
    for (int i = 0; i < quantity; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] creatArray(int[] array, int quantity)
{
    for (int i = 0; i < quantity; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}
Console.Write("Введите желаемое колличество элементов в массиве: ");
int quantity = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[quantity];
numbers = creatArray(numbers, quantity);
printArray(numbers, quantity);
