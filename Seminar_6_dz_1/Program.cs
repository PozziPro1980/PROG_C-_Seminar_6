﻿// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Сколько чисел ввести? ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int [num];

int PositiveNumber(int count)
{
    int countPositive = 0;
    for (int i = 0; i < count; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            countPositive+=1;
        }
        Console.WriteLine(string.Join("," ,array));
    }
    return countPositive;
}
int newCount = PositiveNumber(num);
Console.Write($"Количество положительных чисел = {newCount}");