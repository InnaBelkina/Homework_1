﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число №1");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №2");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
{
    Console.WriteLine ("Число " + number_1 + " больше числа " + number_2);
}
else
{
    Console.WriteLine ("Число " + number_2 + " больше числа " + number_1);
}