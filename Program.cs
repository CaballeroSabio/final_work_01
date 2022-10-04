﻿// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

void Print(int n, int res)
{
    Console.WriteLine($"Сумма чисел от 1 до {n} = {res}");
}

int result = GetSum(num);
Print(num, result);

Console.WriteLine();
