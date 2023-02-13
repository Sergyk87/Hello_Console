/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
*/

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
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

int[,] matrix = InitMatrix(3, 4);

PrintMatrix(matrix);

Console.WriteLine("Введите индекс строки");
int rows = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Введите индекс столбца");
int columns = Convert.ToInt32(Console.ReadLine()) - 1;

if (rows >= 0 && rows < matrix.GetLength(0) && columns >= 0 && columns < matrix.GetLength(1))
{
    Console.WriteLine($"Число на данной позиции :{matrix[rows, columns]}");
}

else
{
    Console.WriteLine("такого элемента нет");
}

