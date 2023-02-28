// Task 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int num){
    return num%100/10;
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>=100 && number<=999) Console.WriteLine(SecondDigit(number));
else Console.WriteLine("Вы ввели не трехзначное число");
*/

//Task 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void FindThirdDigit(int num){
    int countDigits = 0;
    int divisor = 10;

    if(num<100){
        Console.WriteLine("Третьей цифры нет");
    }
    else{
        while(num/divisor>0){
            countDigits+=1;
            divisor*=10;
        }
        while(countDigits>=3){
            num/=10;
            countDigits-=1;
        }
        Console.WriteLine($"Third digit is {num%10}");
    }
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
FindThirdDigit(number);
*/

//Task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool IsWeekend(int num){
    return (num==6 || num==7);
}

bool IsWeekDay(int day){
    return day<=7 && day>0;
}

Console.Write("Input a number(day of the week): ");
int number = Convert.ToInt32(Console.ReadLine());
if(IsWeekDay(number)) 
{
    if(IsWeekend(number)) Console.WriteLine("Это выходной");
    else Console.WriteLine("Это рабочий день");
}
else 
{
    Console.WriteLine("Это не день недели");
}
*/