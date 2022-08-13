/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите пятизначное число:  ");
int userDay = Convert.ToInt32(Console.ReadLine());
string lineNumber = Convert.ToString(userDay);

while (lineNumber.Length < 5 || lineNumber.Length > 5 )
{
    Console.Write("Введите пятизначное число:  ");
    userDay = Convert.ToInt32(Console.ReadLine());
    lineNumber = Convert.ToString(userDay);
}

if (lineNumber[0] == lineNumber[4] && lineNumber[1] == lineNumber[3])
{
    Console.Write($"Число {lineNumber} палиндром.");
}
else
{
    Console.Write($"Число {lineNumber} НE палиндром.");
}
