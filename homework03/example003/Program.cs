/* Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Write("Введите число: ");
double N = Convert.ToDouble(Console.ReadLine());;
double index = 1;
double cube = 0;

while (index <= N)
{
    cube = Math.Pow(index, 3);
    Console.Write($"{cube, 8}"); // 8 кол-во отступов можно (- минус) прижимаем к другому краю
    index++;
    if (index % 10 == 0 )
    {
        Console.WriteLine();
    }
}
