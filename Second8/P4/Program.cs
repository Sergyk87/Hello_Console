/* Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец,
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/

int GetNumber(string message)
{
int result =0;

while (true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result > 0)
break;
else
Console.WriteLine("Вы ввелин не корректное число. Повторите ввод");
}

return result;
}

int [,] InitMatrix(int rows, int columns)
{
int [,] matrix = new int [rows, columns];
Random rnd = new Random();

for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
matrix[i, j] = rnd.Next(0, 10);
}
}
return matrix;
}

void PrintMatrix(int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{