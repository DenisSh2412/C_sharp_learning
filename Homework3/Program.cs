// Task 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool CheckPalindrome(int number){
    if(number/10000 != number%10 || number/1000%10!=number%100/10) return false;
    else return true;
}
// bool CheckPalindromeArray(int number){
//     int[] num = new int[5];
//     int i = 0;
//     while(number>0){
//         num[i] = number%10;
//         number/=10;
//         i+=1;
//     }
//     return num[0] == num[4] && num[1] == num[3];
// }
// bool CheckPalindromeString(int number){
//     string s = number.ToString();
//     return s[0] == s[4] && s[1] == s[3];
// }

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num<=999 || num>=1000000) Console.WriteLine("Вы ввели не пятизначное число");
else{
    if(CheckPalindrome(num)) Console.Write("Число является палиндромом");
    else Console.Write("Число не является палиндромом");
}
*/

// Task 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double[] Input(){
    Console.Write("Введите координату x: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату y: ");
    double y = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату z: ");
    double z = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    double[] res = {x, y, z};
    return res;
}

double CountDistance(double[] arr1, double[] arr2){
    double distant = 0;
    for(int i = 0; i<arr1.Length; i++){
            distant+=Math.Pow(arr1[i]-arr2[i], 2);
        }
    return Math.Round(Math.Sqrt(distant), 2);;
}

double[] coord1 = Input();
double[] coord2 = Input();
Console.WriteLine($"Расстояние = {CountDistance(coord1, coord2)}");
*/

// Task 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i<=N; i++){
    Console.Write(Math.Pow(i, 3) + " ");
}
*/