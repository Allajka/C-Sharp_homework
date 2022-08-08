// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int checkNumber(int numbers)
{
    int amountNumber = 0;
    while (numbers > 0)
    {
        numbers /= 10;
        amountNumber++;
    }
    return amountNumber;
}

int number = 12;
int sumNumber=checkNumber(number);
int control = sumNumber - 3;
int i = 0;

if (sumNumber >= 3)
{
    while (i < control)
    {
        number = number / 10;
        i++;
    }
    int thirdNumber = number % 10;
    Console.WriteLine($"Третья цифра числа {thirdNumber}");
}

if (sumNumber < 3)
{
    Console.WriteLine("Нет третьей цифры");
}

