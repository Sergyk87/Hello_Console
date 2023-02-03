/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


double getNumber(string message)
{
    double result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

double b1 = getNumber("Введите значение b1");

double b2 = getNumber("Введите значение b2");

double k1 = getNumber("Введите значение k1");

double k2 = getNumber("Введите значение k2");

if (k1 == k2)
    Console.Write("Заданные прямые не пересекаются!");

else
{
    double x = (b1 - b2) / (k2 - k1);

    double y = k1 * x + b1;

    Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}







