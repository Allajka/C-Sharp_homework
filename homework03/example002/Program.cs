/* Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

(double x, double y, double z) a, b;
a = (7, -5, 0);
b = (1, -1, 9);

double AC;
double BC;
double CC;
double AB;

if (a.x >= b.x) AC = a.x - b.x;
else AC = b.x - a.x;

if (a.y >= b.y) BC = a.y - b.y;
else BC = b.y - a.y;

if (a.y >= b.y) CC = a.z - b.z;
else CC = b.z - a.z;

AB = Math.Round(Math.Sqrt(Math.Pow(AC, 2) + Math.Pow(BC, 2)+ Math.Pow(CC, 2)),2);
Console.WriteLine(AB);