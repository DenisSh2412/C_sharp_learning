//Task 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int DeleteSecondDigit(int num){
    return num/100*10 + num%10;;
}

int n = new Random().Next(100, 1000);
int result = DeleteSecondDigit(n);
Console.WriteLine($"New version of {n} is {result}");
*/

//Task 2. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
bool CheckDiv(int num, int a, int b){
    return (num % a == 0 && num % b == 0);
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first dividor: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second dividor: ");
int b = Convert.ToInt32(Console.ReadLine());

if(CheckDiv(num, a, b)) Console.WriteLine("Divisible");
else Console.WriteLine("Not Divisible");
*/

//Task 3. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int MaxDigit(int num){
    if((num/10)>(num%10)) return num/10;
    else return num%10;
}
int num = new Random().Next(10, 100);;
int result = MaxDigit(num);
Console.WriteLine($"MaxDigit in {num} is {result}");
*/

//Task 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*
bool CheckSquare(int num1, int num2){
    return (num1*num1==num2 || num2*num2 == num1);
}

Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckSquare(number1, number2));
*/