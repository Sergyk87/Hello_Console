/*
Задача 32: Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]

Алгоритм решения:
1. Инициализируем массив
2. Заполняем массив случайными числами
3. Переворачиваем числа
4. Выводим на экран
*/

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

void ConvertArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

int[] array = InitArray(4);
Console.WriteLine(string.Join(",", array));

ConvertArray(array);
Console.WriteLine(string.Join(",", array));