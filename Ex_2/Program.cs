/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 4; N = 8 -> 30 */

using System;
using static System.Console;

Clear();

Write("Введите первое число: ");
int m = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int n = int.Parse(ReadLine()!);
string k = Numbers(m, n);
int num = int.Parse(k);

SumNumbers(num);
WriteLine(SumNumbers(num));


string Numbers (int m, int n)
{
    if (m == n)
    {
        return m.ToString();
    }
    return m + Numbers(++m, n);
}

int SumNumbers(int num)
{
    if (num == 0)
    {
        return 0;
    }
    return (num % 10 + SumNumbers(num / 10));
}