/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/



double[] InitArray(double dimension)
{
    double[] arr = new double[5];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }

    return arr;
}

double[] array = InitArray(5);
Console.WriteLine(string.Join(" ", array));

double diff = array.Max() - array.Min();
Console.WriteLine($"Разница между максимальным и минимальным числом равна {diff}");