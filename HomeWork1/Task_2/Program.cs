/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число");
String namber1 = Console.ReadLine();
int a = Convert.ToInt32(namber1);

Console.WriteLine("Введите второе число");
String namber2 = Console.ReadLine();
int b = Convert.ToInt32(namber2);

Console.WriteLine("Введите третье число");
String namber3 = Console.ReadLine();
int c = Convert.ToInt32(namber3);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);