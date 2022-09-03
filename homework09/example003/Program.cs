/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

/* Попытка решить самостоятельно без решения из Википедии
double AckermanFunctions(double m, double n)
{
    if (n == 0) return m + 1;
    else if (n > 0 && m == 1) return n + 2;
    else if (n > 0 && m == 2) return 2 * n + 3;
    else if (n > 0 && m == 3) return Math.Pow(2, n + 3) - 3;
    return -1; 
}
Console.WriteLine($" Значение A({m},{n}) = {AckermanFunctions(m, n)}"); */

int AckermanFunctionsRecursion(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    {
        if (m != 0 && n == 0) return AckermanFunctionsRecursion(m - 1, 1);
        else return AckermanFunctionsRecursion(m - 1, AckermanFunctionsRecursion(m, n - 1));
    }
}

int CheckInput(string text, int number = 0)
{
    while (true)
    {
        Console.Write($"{text}: ");
        string input = Console.ReadLine()!;
        bool flag = int.TryParse(input, out number);
        if (flag && number >= 0) break;
    }
    return number;
}

Console.WriteLine("Программа, вычисления функции Аккермана A(m,n).");
int m = CheckInput("Введите положительное число m: ");
int n = CheckInput("Введите положительное число n: ");

Console.WriteLine($" Значение A({m},{n}) = {AckermanFunctionsRecursion(m, n)}");