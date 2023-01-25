/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 6 && number <= 7)
{
    Console.WriteLine("Поздравляю, сегодня выходной!");
}
else if (number >= 1 && number <= 5)
{
    Console.WriteLine("Это будний день, нужно еще поработать...");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}
