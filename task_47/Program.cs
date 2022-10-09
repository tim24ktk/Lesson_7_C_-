/*
    Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

double[,] InitMatrix(int m, int n, int min, int max)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// проверка работы написаных методов

int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
double[,] matrix = InitMatrix(m, n, -10, 10);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);
