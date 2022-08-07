// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int controlNumber = Convert.ToInt32(Console.ReadLine());
int count = 1;
string evenNumbers = "";

while (count < controlNumber)
{
    if((count % 2) == 0) evenNumbers = evenNumbers + count + " ";
    count++;
}

Console.WriteLine(evenNumbers);
