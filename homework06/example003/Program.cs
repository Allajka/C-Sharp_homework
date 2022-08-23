/* Написать алгоритм поворота матрицы [N;N] на 90 градусов
    012     012
0   123  0  741    
1   456  1  852
2   789  2  963 */

int[,] picture = new int[,]
{
    {1, 0, 0, 0, 0},
    {1, 0, 0, 0, 0},
    {1, 0, 0, 0, 0},
    {1, 0, 0, 0, 0},
    {1, 1, 1, 1, 1},
};

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

PrintPicture(picture);
System.Console.WriteLine();

for (int i = 0; i < picture.GetLength(0); i++)
{

    // for (int j = 0; j < picture.GetLength(1); j++)
    // {
    //     int temporary = picture[i, j];
    //     picture[i, j] = picture[j, picture.GetLength(1) - 1 - i];
    //     picture[j, picture.GetLength(1) - 1 - i] = temporary;
    // }
    for (int j = 0; j < picture.GetLength(1); j++)
    {
        int temporary = picture[j, i];
        picture[j, i] = picture[picture.GetLength(1) - 1 - i, j];
        picture[picture.GetLength(1) - 1 - i, j] = temporary;
    }
}

PrintPicture(picture);
System.Console.WriteLine();