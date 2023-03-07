// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел
/*
int Count(int num){
    int sum = 0;
    for(int i = 1; i<=num; i++){sum+=i;}
    return sum;
}

Console.Write("Input a number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum is {Count(A)}");
*/

//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int CountNum(int num){
    int count = 0;
    while(num>0){
        count+=1;
        num/=10;
    }
    return count;
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number of digits: {CountNum(n)}");
*/

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
/*
int Mul(int num){
    int mul = 1;
    for(int i = 1; i<=num; i++){mul*=i;}
    return mul;
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result is {Mul(n)}");
*/
//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
/*
void MakeArr(int[] arr){
    for(int i = 0;i<arr.Length; i++){
        arr[i] = new Random().Next(0, 2);
    }
    for(int i = 0;i<arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
}

int[] mass = new int[8];
MakeArr(mass);
*/