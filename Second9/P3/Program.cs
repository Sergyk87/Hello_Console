/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int SumOfNumbers(int number)
{
    if (number == 0)
        return number;
    else
        return number % 10 + SumOfNumbers(number / 10);
}
int sum = SumOfNumbers(453); // сумма цифр числа
Console.WriteLine(sum);