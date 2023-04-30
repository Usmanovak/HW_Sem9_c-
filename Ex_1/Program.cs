/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

using System;
using static System.Console;

Clear();

Write("Число: ");
int N = int.Parse(ReadLine()!);
int start = 1;
Write(ReverseNum(start, N));


string ReverseNum (int start, int N)
{
    if (N == start)
    {
        return N.ToString();
    }
    return N + ", " + ReverseNum(start, --N);
}



