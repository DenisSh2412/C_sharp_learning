// Task 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Pow(int a, int b){
    int i = 0;
    int res = 1;
    while(i<b){
        res*=a;
        i+=1;
    }
    return res;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result is {Pow(num1, num2)} ");
*/

// Task 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
/*
int SumOfDigits(int a){;
    int sum = 0;
    int new_a = Math.Abs(a);
    while(new_a>0){
        sum+=new_a%10;
        new_a/=10;
    }
    return sum;
}

Console.Write("Input your number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits is {SumOfDigits(num1)} ");
*/

// Task 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
/*
int[] MakeArray(string s){;
    string[] new_s = s.Split(", ");
    int[] num = new int[new_s.Length];
    for(int i = 0; i<new_s.Length; i++){
        num[i] = Convert.ToInt32(new_s[i]);
    }
    return num;
}

void PrintArray(int[] arr){;
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++){
        Console.Write(arr[i]+", ");
    }
    Console.Write(arr[arr.Length-1]+"]");
}

Console.Write("Input numbers: ");
string line = Console.ReadLine();
int[] arr = MakeArray(line);
PrintArray(arr);
*/
