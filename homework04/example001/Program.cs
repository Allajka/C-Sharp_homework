/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("Введите число: ");
int userA = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите натуральную степень для возведения числа {userA}: ");
int userB = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 1; i <= userB; i++)
{
    result *= userA;
}
Console.WriteLine(result);