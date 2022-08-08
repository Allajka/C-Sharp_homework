// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int userNumber = new Random().Next(100, 1000);
int middleNumber = (userNumber / 10) % 10;

Console.WriteLine($"число {userNumber}, вторая цифра числа {middleNumber}");

