﻿/*Задача 1: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("введите первое число ");

int numA = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("введите второе число ");

int numB = Convert.ToInt32(Console.ReadLine());

// заводим переменные

int max = 0;
int min = 0;

if (numA > numB) 
{
    max = numA;
    min = numB;
    Console.WriteLine("max = ");
    Console.WriteLine(max);
    Console.WriteLine("min = ");
    Console.WriteLine(min);
}   
if (numA < numB)
{
    max = numB;
    min = numA;
    Console.WriteLine("max = ");
    Console.WriteLine(max);
    Console.WriteLine("min = ");
    Console.WriteLine(min);
}

if (numA == numB)
{
    Console.WriteLine("числа равны ");
}

