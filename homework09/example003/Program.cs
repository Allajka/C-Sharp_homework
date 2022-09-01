/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

double m = 3;
double n = 2;

double Metod(double m, double n, double result = 0)
{
    if (m >= 3) return result += Math.Pow(2, n + 3) - 3;
    else result += m * n + 1;
    Console.WriteLine($"result: {result}");
    if (m == 0) return result;
    else return Metod(m - 1, n, result);
}

System.Console.WriteLine(Metod(m, n));