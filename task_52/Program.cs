/*
    Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// метод получения данных от пользователя
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

// метод инициализации двумерного массива
int[,] InitMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(max - min);
        }
    }

    return matrix;
}

// вывод двумерного массива(матрицы) в консоль
void PrintMatrix(int[,] matrix)
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

// метод посдсчета среднего арифметического элементов в каждом столбце
string GetAverage(int[,] matrix)
{
    string averageValues = string.Empty;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }

        averageValues += $"{Math.Round(sum / matrix.GetLength(0), 1)};";
    }

    return averageValues;
}

// проверка работы написаных методов
int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
int[,] matrix = InitMatrix(m, n, 1, 10);
string getAverage = GetAverage(matrix);

Console.WriteLine("Задан массив:");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца: {getAverage}");
