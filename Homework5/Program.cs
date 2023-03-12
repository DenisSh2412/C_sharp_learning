// Task 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве
/*
int countEven(int[] arr){
    Random rand = new Random();
    int count = 0;
    for(int i = 0; i<arr.Length; i++){
        arr[i] = rand.Next(100, 1000);
        if(arr[i]%2==0) count+=1;
    }
    return count;
}
void PrintArray(int[] arr, int n){
    Console.WriteLine(string.Join(" ", arr));
    Console.Write($"Количество четных чисел в массиве = {n} ");
}

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
PrintArray(arr, countEven(arr));
*/

// Task 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
long sumofOddPositions(int[] arr){
    Random rand = new Random();
    long sum = 0;
    for(int i = 0; i<arr.Length; i++){
        arr[i] = rand.Next(-100, 100);
        if(i%2!=0) {sum+=arr[i];}
    }
    return sum;
}
void PrintArray(int[] arr, long n){
    Console.WriteLine(string.Join(" ", arr));
    Console.Write($"Сумма элементов на нечетных позициях = {n} ");
}

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
PrintArray(arr, sumofOddPositions(arr));
*/

//Task 3. Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива.
/*
double diffMinMax(double[] arr){
    Random rand = new Random();
    double min = 0;
    double max = 0;
    for(int i = 0; i<arr.Length; i++){
        arr[i] = Math.Round(rand.NextDouble()*20, 2);
        if(i==0) {
            min = arr[i];
            max = arr[i];
        }
        else{
            if(arr[i]<min) min = arr[i];
            if(arr[i]>max) max = arr[i];
        }
    }
    return max-min;
}

void PrintArray(double[] arr, double n){
    Console.WriteLine(string.Join(" ", arr));
    Console.Write($"Разница между максимальным и минимальным элементами массива = {n}");
}

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[n];
PrintArray(arr, diffMinMax(arr));
*/