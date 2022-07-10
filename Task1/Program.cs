// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
    : a<b? a + Product(++a,b)
    : b + Product(a, ++b);
}