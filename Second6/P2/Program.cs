﻿/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.*/

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2)
    Console.WriteLine("Треугольник существует!");
    
else
    Console.WriteLine("Треугольник не может существовать!");