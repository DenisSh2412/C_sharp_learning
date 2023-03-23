// Task 1(54). Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] MakeArray(){
    Random rand = new Random();
    int[,] arr = new int[rand.Next(2, 7), rand.Next(2, 7)];
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

void SortRow(int[] array){
    for(int i = 0; i<array.Length; i++){
        for(int j = 0; j<array.Length; j++){
            if(array[j]<array[i]){
                int tmp = array[i];
                array[i]=array[j];
                array[j]=tmp;
            }
    }
    }
}

int[,] SortArray(int[,] arr){
    int[,] arrNew = new int[arr.GetLength(0), arr.GetLength(1)];
    for(int i = 0; i<arr.GetLength(0); i++){
        int[] sortArr = new int[arr.GetLength(1)];
        for(int j = 0; j<arr.GetLength(1); j++){
            sortArr[j] = arr[i, j];
        }
        SortRow(sortArr);
        for(int k = 0; k<arr.GetLength(1); k++){
            arrNew[i, k] = sortArr[k];
        }

    }
    return arrNew;
}

Console.WriteLine("Случайный массив: ");
int[,] newarr = MakeArray();
PrintArray(newarr);
Console.WriteLine("Отсортированные строки массива: ");
PrintArray(SortArray(newarr));
*/




// Task 2(56). Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] MakeArray(){
    Random rand = new Random();
    int[,] arr = new int[rand.Next(2, 7), rand.Next(2, 7)];
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

int FindSum(int[] array){
    int sum = 0;
    for(int i = 0; i<array.Length; i++){
        sum+=array[i];
    }
    return sum;
}

int FindMinArray(int[,] arr){
    int minSumIndex = 0;
    int minSum = 0;
    for(int i = 0; i<arr.GetLength(0); i++){
        int[] rowArr = new int[arr.GetLength(1)];
        for(int j = 0; j<arr.GetLength(1); j++){
            rowArr[j] = arr[i, j];
        }
        int sum = FindSum(rowArr);
        if(i==0){
            minSumIndex = 0;
            minSum = sum;
        }
        else{
            if(minSum>sum){
                minSumIndex = i;
                minSum = sum;
            }
        }

    }
    return minSumIndex;
}

Console.WriteLine("Случайный массив: ");
int[,] newarr = MakeArray();
PrintArray(newarr);
Console.WriteLine($"Индекс строки с минимальной суммой: {FindMinArray(newarr)}");
*/




// Task 3(60). Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
/*
int[,,] MakeArray(int n, int m, int l){
    Random rand = new Random();
    int prom = 0;
    int[,,] arr = new int[n, m, l];
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            for(int k = 0; k<arr.GetLength(2); k++){
                if(i==0 && j==0 && k==0) 
                {
                    arr[i, j, k] = rand.Next(-50, 50);
                    prom = arr[i, j ,k];
                }
                else{
                    arr[i, j, k] = prom + rand.Next(1, 10);
                    prom = arr[i, j, k]; 
                }
            } 
            }
    }
    return arr;
}

void PrintArray(int[,,] arr){
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            for(int k = 0; k<arr.GetLength(2); k++){
                Console.Write($"{arr[i, j, k]}({i}, {j}, {k})"+ "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Массив неповторяющихся чисел: ");
int[,,] newarr = MakeArray(2, 2, 2);
PrintArray(newarr);
*/




//Дополнительные задачи


// Task 4(58). Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] MakeArray(int row, int col){
    Random rand = new Random();
    int[,] arr = new int[row, col];
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            arr[i, j] = rand.Next(-10, 10); 
            }
    }
    return arr;
}

int[,] Multiply(int[,] arr1, int[,] arr2){
    int[,] arr = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for(int i = 0; i<arr1.GetLength(0); i++){
        for(int j = 0; j<arr2.GetLength(1); j++){
            int sum = 0;
            for(int k = 0; k<arr1.GetLength(1); k++){
                sum+=arr1[i, k]*arr2[k, j];
            }
            arr[i, j] = sum;
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

Console.Write("Введите количество строк первой матрицы: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int m2 = Convert.ToInt32(Console.ReadLine());
int[,] array1 = MakeArray(n1, m1);
int[,] array2 = MakeArray(n2, m2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
if(m1!=n2){
    Console.Write("Нельзя перемножить матрицы");
}
else{
    Console.WriteLine();
    PrintArray(Multiply(array1, array2));
}
*/




// Task 5(62). Напишите программу, которая заполнит спирально массив 4 на 4
/*
int[,] MakeArray(){
    Random rand = new Random();
    int[,] arr = new int[4, 4];
    arr[0, 0] = rand.Next(-10, 10); 
    return arr;
}

void MakeHelix(int[,] arr){
    int count = 0;
    int up = 0;
    int down = arr.GetLength(0)-1;
    int left = 0;
    int right = arr.GetLength(1)-1;
    while(up<down && left<right){
        for(int i = left; i<=right; i++){
            arr[up, i] = arr[0,0]+count;
            count+=1;

        }
        up+=1;

        for(int i = up; i<=down; i++){
            arr[i, right] = arr[0,0]+count;
            count+=1;

        }
        right-=1;

        if(up<=down){
            for(int i = right; i>=left; i--){
                arr[down, i] = arr[0,0]+count;
                count+=1;

            }
            down-=1;
        }
        if(left<=right){
            for(int i = down; i>=up; i--){
                arr[i, left] = arr[0,0]+count;
                count+=1;

            }
            left+=1;
        }
    }
}

void PrintArray(int[,] arr){
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            Console.Write(arr[i, j]+ "\t");
        }
        Console.WriteLine();
    }
}
int[,] newarr = MakeArray();
MakeHelix(newarr);
PrintArray(newarr);
*/




// Task 6(59). Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
/*
int[,] MakeArray(){
    Random rand = new Random();
    int[,] arr = new int[rand.Next(2, 7), rand.Next(2, 7)];
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            arr[i, j] = rand.Next(-10, 10); 
            }
    }
    return arr;
}
int[] FindMin(int[,] array){
    int[] min = {0, 0};
    int minim = array[0, 0];
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            if(array[i, j]<minim){
                min[0] = i;
                min[1] = j;
                minim = array[i, j];
            }
            }
    }
    return min;
}

void PrintArray(int[,] arr){
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            Console.Write(arr[i, j]+ "\t");
        }
        Console.WriteLine();
    }
}

int[,] ArrayWithoutMin(int[,] arr, int[] min){
    int[,] new_arr = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    int[] znach = new int[arr.GetLength(0)*arr.GetLength(1)-2];
    int k = 0;
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            if(i!=min[0] && j!=min[1]){
                znach[k] = arr[i, j];
                k+=1;
            }
            }
    }

    for(int i = 0; i<new_arr.GetLength(0); i++){
        for(int j = 0; j<new_arr.GetLength(1); j++){
            new_arr[i, j] = znach[i*new_arr.GetLength(1)+j];
            }
    }
    return new_arr;

}

int[,] newarr = MakeArray();
PrintArray(newarr);
int[,] arrWithoutMin = ArrayWithoutMin(newarr, FindMin(newarr));
Console.WriteLine();
PrintArray(arrWithoutMin);
*/



//Task 7(61). Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
/*
int[,] MakePascalTriangle(int n){
    int[,] triangle = new int[n+1, (2*n)+3];
    for(int i = 0; i<triangle.GetLength(0)-1; i++){
        for(int j = 1; j<triangle.GetLength(1)-1; j++){
            if(i==0){
                triangle[i,triangle.GetLength(1)/2]=1;
                break;
            }
            if(i==1){
                triangle[i,triangle.GetLength(1)/2-1]=1;
                triangle[i, triangle.GetLength(1)/2+1]=1;
                break;
            }
            else{
            triangle[i, j] = triangle[i-1, j-1]+triangle[i-1, j+1];
            }
        }
    }
    return triangle;

}

void PrintArray(int[,] arr){
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            if(arr[i, j]!=0) Console.Write(arr[i, j]+ "\t");
            else Console.Write("\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк треугольник Паскаля: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintArray(MakePascalTriangle(n));
*/
