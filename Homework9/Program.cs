// Task 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
/*
void PrintNum(int N){
    if(N==0){
        return;
    }
    Console.Write(N+" ");
    PrintNum(N-1);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNum(number);
*/


//Task 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int Sum(int n, int m){
    if(m-1==n){
        return 0;
    }

    return m + Sum(n, m+1);
}


Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма равна = {Sum(n, m)}");
*/

//Task 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
/*
int AkkerMan(int m, int n){
    if(m==0){
        return n+1;
    }
    if(m>0 && n==0){
        return AkkerMan(m-1, 1);
    }
    if(m>0 && n>0){
        return AkkerMan(m-1, AkkerMan(m, n-1));
    }
    return AkkerMan(m,n);

}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана А({m}, {n}) = {AkkerMan(m, n)}");
*/

