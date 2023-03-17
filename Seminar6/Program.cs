// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
/*
int[] FillArrayWhithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}
void ReverseArray(int[] arr)
{
    int temp = 0;
    for(int i = 0; i < arr.Length/2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}
System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
ReverseArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
*/

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.
/*
System.Console.WriteLine("Введите сторону 1 сторону треугольника");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите сторону 2 сторону треугольника");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите сторону 3 сторону треугольника");
int c = Convert.ToInt32(Console.ReadLine());
string ExistenseTriangle(int a,int b, int c)
{
    if(a+b>c && b+c>a && c+a>b) return "Треугольник с заданными сторонами существует";
    return "Треугольник с заданными сторонами не существует";
}
System.Console.WriteLine(ExistenseTriangle(a,b,c));
*/
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
/*
void PrintBinary(int number)
{
if(number <= 0)
{
return;
}
PrintBinary(number/2);
Console.Write(number%2);
}
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintBinary(number);
// Второй вариант
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int end = 0;
while (num1 > 0)
{
end = num1 % 2;
num1 /= 2;
Console.Write(end);
}
//Третий вариант
int SizeofDif(int num)
{
int count = 0;
while (num > 0)
{
    num /= 2;
    count++;
}
return count;
}
int[] Dif(int num)
{
int[] arr = new int[SizeofDif(num)];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = num % 2;
    num /= 2;
}
return arr;
}
int[] Reverse(int[] someArr)
{
for (int i = 0; i < someArr.Length/2; i++)
{
    int temp = someArr[i];
    someArr[i] = someArr[someArr.Length - 1 - i];
    someArr[someArr.Length - 1 - i] = temp;
}
return someArr;
}
int[] result = Dif(2);
Console.WriteLine($"Your array: [{string.Join(", ", result)}]");
int[] newArr = Reverse(result);
Console.WriteLine($"Reverse array: [{string.Join(", ", newArr)}]");
*/

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
/*
void PrintFibToN(int N)
{
int fib1 = 0;
int fib2 = 1;
int fib3 = 0;
Console.Write("0 1 ");
for(int i = 0; i < N - 2; i++)
{
fib3 = fib1 + fib2;
Console.Write($"{fib3} ");
fib1 = fib2;
fib2 = fib3;
}
}
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintFibToN(number);
//Второй вариант решения
Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
array[0] = 0;
array[1] = 1;
for(int i = 2; i < number; i++){
array[i] = array[i-2] + array[i-1];
}
Console.Write("Array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");
*/