﻿/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод.");
        }
    }

    return result;
}


int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}    ");
        }

        Console.WriteLine();
    }
}


void SumStringMatrix(int[,] matrix)
{
    int minSumString = 0;
    int minString = 0;
    int sumString = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minSumString += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumString += matrix[i, j];
        if (sumString < minSumString)
        {
            minSumString = sumString;
            minString = i;
        }
        sumString = 0;
    }
    Console.Write($"Номер строки с наименьшей суммой элементов:{minString + 1}");
}

int countOfRows = GetNumber("Введите кол-во строк:");
int countOfColumns = GetNumber("Введите кол-во столбцов:");
Console.WriteLine();

int[,] matrix = InitMatrix(countOfRows, countOfColumns);
PrintMatrix(matrix);

SumStringMatrix(matrix);
