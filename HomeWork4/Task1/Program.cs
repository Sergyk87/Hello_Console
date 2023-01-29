/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число(число должно быть натуральным):");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < Math.Abs(b); i++)
{
    result = (result * a);
}
Console.WriteLine($"Если число {a} возвести в натуральную степень числа {b} получится {result}");