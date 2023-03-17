// Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
using System.Text.RegularExpressions;
int countPositiveNumbers(string s){
    int count = 0;
    Regex regex = new Regex("[ ]+");         // Split on hyphens.
    string[] numbers = regex.Split(s);
    for(int i = 0; i<numbers.Length; i++)
    {
        if(Convert.ToInt32(numbers[i])>0) count+=1;
    }
    return count;
}
Console.WriteLine("Введите числа: ");
string read = Console.ReadLine();
Console.WriteLine($"Число положительных чисел = {countPositiveNumbers(read)}");
*/

// Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void findIntersection(int k1, int b1, int k2, int b2){
    if(k1==k2 && b1!=b2){
        Console.WriteLine("Прямые параллельны");
    }
    else if(k1==k2 && b1==b2){
        Console.WriteLine("Прямые совпадают");
    }
    else{
        double z = (double)(b2-b1)/(k1-k2);
        Console.WriteLine($"Точка пересечения: ({z}, {k1*z+b1})");
    }
}


Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
findIntersection(k1, b1, k2, b2);
*/



