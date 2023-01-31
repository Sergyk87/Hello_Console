/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/



Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) < 10)
{
    Console.WriteLine("Ввели число состоящее из одного элемента, сумму посчитаь невозможно");
}
else
{
    int sum = 0;
    while (number > 0)
    {
        int a = number % 10;
        number = number / 10;
        sum = sum + a;
    }

    Console.WriteLine("сумма цифр в числе равна: " + sum);
}