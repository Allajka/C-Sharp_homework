/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 4 */

int count = 0;
Console.WriteLine("Подсчет чисел больше 0. Для прекращения введите q.");

while (true)
{
    Console.Write("Введите число: ");
    string number = Console.ReadLine()!;
    number.ToLower();
    if (number == "q") break;
    if (Convert.ToInt32(number) > 0) count++;
}

Console.WriteLine($"Введено {count} чисел больше 0.");