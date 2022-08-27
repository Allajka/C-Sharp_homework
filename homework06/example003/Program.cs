/* Написать алгоритм поворота матрицы [N;N] на 90 градусов */
void PrintPicture(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == 0) Console.Write(" ");
            else Console.Write("*");
        }
        Console.WriteLine();
    }
}
int[,] TurnArray(int[,] arr)
{
    int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            newArr[i,j] = arr[arr.GetLength(0) - j - 1, i];
        }
    }

    return newArr;
}

int[,] picture = new int[,]
{
    {1, 0, 0, 0, 0},
    {1, 0, 0, 0, 0},
    {1, 0, 0, 0, 0},
    {1, 0, 0, 0, 0},
    {1, 1, 1, 1, 1},
};

PrintPicture(picture);
System.Console.WriteLine();
while(true)
{
    Console.Write("Нажмите q для выхода.\nНажмите любую букву для поворота фигуры: ");
    string userAnswer = Console.ReadLine()!;
    userAnswer.ToLower();
    if (userAnswer == "q" || userAnswer == "Й") break;
    picture = TurnArray(picture);
    System.Console.WriteLine();
    PrintPicture(picture);
    System.Console.WriteLine();
}
