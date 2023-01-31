/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

//1. инициализируем массив
//2. печатаем массив
//3. находим кол-во четных чисел

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(100, 1000);
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
int EvenNumber(int[] arr)
{
    int number = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            number++;
    }
    return number;
}

int[] array = InitArray(10);
PrintArray(array);
int EvenNumberSum = EvenNumber(array);
Console.WriteLine($"количество чётных чисел в массиве: {EvenNumberSum}");