/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

//1. инициализируем массив
//2. печатаем массив
//3. находим сумму элементов на нечетных позициях

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(0, 10);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int GetNegativeNumberSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + arr[i];
    }
    return sum;
}

int[] array = InitArray(10);
PrintArray(array);
int NegNumberSum = GetNegativeNumberSum(array);
Console.WriteLine($"Сумма элементов на нечетных позициях равна: {NegNumberSum}");