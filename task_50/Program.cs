/*
    Задача 50. Напишите программу,
    которая на вход принимает число и возвращает позицию (i, j) этого элемента
    или же указание, что такого элемента нет.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    17 -> такого числа в массиве нет
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

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

string GetElementPosition(int value, int[,] matrix)
{
    bool isExists = false;
    int rowIndex = 0;
    int columnIndex = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == value)
            {
                isExists = true;
                rowIndex = i;
                columnIndex = j;
            }
        }
    }

    if (isExists)
    {
        return $"({rowIndex}, {columnIndex})";
    }
    else
    {
        return "Такого элемента нет!";
    }
}

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

// проверка работы написаных методов

int value = GetNumber("Введите элемент: ");
int m = GetNumber("Введите число m: ");
int n = GetNumber("Введите число n: ");
int[,] matrix = InitMatrix(m, n, 0, 10);
string getElementPosition = GetElementPosition(value, matrix);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine(getElementPosition);
