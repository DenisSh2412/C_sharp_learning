﻿// Task 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2) 
{
Console.WriteLine($"max = {num1}, min = {num2}");
}
else 
{
Console.WriteLine($"max = {num2}, min = {num1}");
}
*/

// Task 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;
Console.WriteLine(max);
*/

// Task 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0) Console.WriteLine("да, число четное");
else Console.WriteLine("нет, число нечетное");
*/

// Task 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a positive number: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count <= N)
{
    if(count % 2 == 0)
    { 
    Console.Write(count + " ");
    }
    count+=1;
}
*/