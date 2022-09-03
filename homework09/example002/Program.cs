/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumNumbers(int firstNumber, int lastNumber, int sum = 0)
{
    if (firstNumber > lastNumber) return 0;
    else return firstNumber + SumNumbers(firstNumber + 1, lastNumber, sum);
}

int CheckInput(string text, int number = 0)
{
    while (true)
    {
        Console.Write($"{text}: ");
        string input = Console.ReadLine()!;
        bool flag = int.TryParse(input, out number);
        if (flag) break;
    }
    return number;
}

Console.WriteLine("Программа, которая найдёт сумму натуральных элементов в промежутке от M до N.");
int m = CheckInput(text: "Задайте начало интервала, М = ");
int n = CheckInput(text: "Задайте конец интервала, N = ");
if (m > n) Console.WriteLine($"{m} больше {n}");
else Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {SumNumbers(firstNumber: m, lastNumber: n)}");