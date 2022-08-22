/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

k1 = 5, b1 = 2,  
k2 = 9, b2 = 4, 
(-0,5; -0,5) */

double k1 = Convert.ToInt32(Console.ReadLine());
double b1 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 || k1 == 0 || k2 == 0)
{
    Console.WriteLine("Нет точек пересечения");
}
else
{
    double x = - (b1 - b2)/(k1 - k2);
    double y = k2 * x + b2;
    System.Console.WriteLine($"Точка пересечения двух прямых ({Math.Round(x, 2)}; {Math.Round(y, 2)}).");
}


