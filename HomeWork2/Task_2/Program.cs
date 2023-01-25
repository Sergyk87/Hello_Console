/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/


Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if (number < 100 && number > -99)
{
    Console.WriteLine("в данном числе нет третьей цифры, попробуйте еще раз...");
}
else
if (number > 99)
{
    Console.WriteLine($"Третья цифра вашего числа числа: {numberStr[2]}");
}
if (number < -99)
{
    Console.WriteLine($"Третья цифра вашего числа числа: {numberStr[3]}");
}