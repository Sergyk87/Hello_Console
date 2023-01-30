/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/



Console.WriteLine("Введите любое число");
int namber = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (namber > 0)
{
    int a = namber % 10;
    namber = namber / 10;
    sum = sum + a;
}
Console.WriteLine("сумма цифр в числе равна: " + sum);