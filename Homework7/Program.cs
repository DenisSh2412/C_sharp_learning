// Task 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
/*
void FillArray(double[,] arr){
    Random rand = new Random();
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            arr[i, j] = Math.Round(rand.Next(-50, 50) + rand.NextDouble(), 2);
        }
    }
}

void PrintArray(double[,] arr){
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            Console.Write(arr[i, j]+ "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[n, m];
FillArray(array);
PrintArray(array);

*/
//Task 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет
/*
void IndexorNumber(int[,] arr){
    Console.WriteLine("Введите команду: 1-поиск по индексу, 2-поиск по элементу");
    string s = Console.ReadLine();
    if(s=="1"){
        Console.Write("Введите строку для элемента: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите столбец для элемента: ");
        int m = Convert.ToInt32(Console.ReadLine());
        CheckIndex(n, m, arr);
    }
    else if(s=="2"){
        Console.Write("Введите число для поиска: ");
        int n = Convert.ToInt32(Console.ReadLine());
        CheckNumber(n, arr);
    }
    else{
        Console.Write("Вы ввели неправильную команду");
    }
}

int[,] MakeArray(){
    Random rand = new Random();
    int[,] arr = new int[rand.Next(2, 10), rand.Next(2, 10)];
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            arr[i, j] = rand.Next(-10, 10); 
            }
    }
    return arr;
}
void PrintArray(int[,] arr){
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            Console.Write(arr[i, j]+ "\t");
        }
        Console.WriteLine();
    }
}

void CheckNumber(int n, int[,] arr){
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            if(arr[i,j]==n){
                Console.WriteLine($"Индексы числа: [{i}, {j}]");
                return ;
            } 
        }
    }
    Console.WriteLine("Такого числа в массиве нет");
}

void CheckIndex(int n, int m, int[,] arr){
    if(n<arr.GetLength(0) && m<arr.GetLength(1) && n>=0 && m>=0){
        Console.WriteLine($"{arr[n, m]}");
    }
    else{
        Console.WriteLine("Такого числа в массиве нет");
    }
}

Console.WriteLine("Случайный массив: ");
int[,] newarr = MakeArray();
PrintArray(newarr);
IndexorNumber(newarr);
*/


//Task 3. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] MakeArray(int n, int m){
    Random rand = new Random();
    int[,] arr = new int[n, m];
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            arr[i, j] = rand.Next(-10, 10); 
            }
    }
    return arr;
}

void PrintArray(int[,] arr){
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            Console.Write(arr[i, j]+ "\t");
        }
        Console.WriteLine();
    }
}

void CountAverage(int[,] arr){
    Console.WriteLine("Средние арифметические по столбцам: ");
    for(int i = 0; i<arr.GetLength(1); i++){
        double aver = 0;
        for(int j = 0; j<arr.GetLength(0); j++){
            aver+=arr[j, i];
        }
        Console.Write($"{Math.Round(aver/arr.GetLength(0), 2)}" + "\t");
    }

}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = MakeArray(n, m);
PrintArray(array);
CountAverage(array);
*/
