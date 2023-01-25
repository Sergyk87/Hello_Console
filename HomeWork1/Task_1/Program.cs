/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите первое число");
String namber1 = Console.ReadLine();
int a = Convert.ToInt32(namber1);

Console.WriteLine("Введите второе число");
String namber2 = Console.ReadLine();
int b = Convert.ToInt32(namber2);

if (a > b)
{
    Console.WriteLine("Первое число большее, а второе меньшее");
}
else
{
    Console.WriteLine("Второе число большее, а первое меньшее");
}