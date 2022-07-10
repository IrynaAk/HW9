// Задача 64: Задайте значения M и N. Напишите программу, которая выведет произведение натуральных чисел в промежутке от M до N.
// M = 1; N = 5. ->120
// M = 4; N = 6. -> 120

using System;
using static System.Console;
Clear();

WriteLine("Please type M: ");
int M = int.Parse(ReadLine());
WriteLine("Please type N: ");
int N = int.Parse(ReadLine());

WriteLine(Product(M, N));

int Product(int a, int b)
{
    return a==b? b
    : a<b? a * Product(++a,b)
    : b* Product(a, ++b);
}