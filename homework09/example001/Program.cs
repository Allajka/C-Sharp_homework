/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 5, 7, 8"" */

void PrintNumberLine(int firstNumber, int lastNumber)
{
    if (firstNumber == lastNumber) Console.Write($"{lastNumber}");
    else if (firstNumber > lastNumber) Console.Write($"{lastNumber} меньше {firstNumber}.");
    else
    {
        Console.Write($"{firstNumber} ");
        PrintNumberLine(firstNumber + 1, lastNumber);
    }
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

Console.WriteLine("Программа, которая выведет все натуральные числа в промежутке от M до N.");
int m = CheckInput(text: "Задайте начало интервала, М = ");
int n = CheckInput(text: "Задайте конец интервала, N = ");
PrintNumberLine(m, n);