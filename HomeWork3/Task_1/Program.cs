/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("Введите пятизначное число");
string numberStr = Console.ReadLine();
int number = numberStr.Length;

if (number == 5)
{
    if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
    {
        Console.WriteLine($"число {numberStr} является палиндромом");
    }
    else
    {
        Console.WriteLine($"число {numberStr} не является палиндромом");
    }
}
else 
{
    Console.WriteLine("это число не является пятизначным");
}



  

