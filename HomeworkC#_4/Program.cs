﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

for (int a = 2; a <= N; a += 2) Console.WriteLine(a);


