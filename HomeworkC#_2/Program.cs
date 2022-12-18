// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число №1");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №2");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №3");
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if (number_2 > max)
{
    max = number_2;
}

if (number_3 > max)
{
    max = number_3;
}

Console.WriteLine ($"Максимальное число {max}");

