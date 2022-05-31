/*Задача 2: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/


Console.WriteLine("введите три числа, через интер ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (max < numA) max = numA;
if (max < numB) max = numB;
if (max < numC) max = numC;
{
    Console.WriteLine("max =");
    Console.WriteLine(max);
}
Console.WriteLine("\n");