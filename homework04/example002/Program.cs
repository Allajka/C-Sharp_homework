/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int box = number;
int sum = 0;
while (box > 0)
{ 
sum += box % 10;
box = box /10 ;
}

Console.WriteLine($"Сумма цифр в числе {number} = {sum}");