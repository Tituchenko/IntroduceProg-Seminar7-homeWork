//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

//m = 3, n = 4.

//1 7 -2 -85

//1 -3 8 -9

//8 7 -7 9
/*
Console.WriteLine ("Введите количество строк: ");
int rows=int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите количество столбцов: ");
int columns=int.Parse(Console.ReadLine()!);

int [,] Array= GetArray(rows,columns,-9,9);
PrintArray(Array);


*/
/*
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//i = 4, j = 2 -> такого числа в массиве нет
//i = 1, j = 2 -> 2

Console.WriteLine ("Введите количество строк: ");
int rows=int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите количество столбцов: ");
int columns=int.Parse(Console.ReadLine()!);

int [,] Array2= GetArray(rows,columns,-9,9);
PrintArray(Array2);
Console.Write ("i=");
int i=int.Parse(Console.ReadLine()!);

Console.Write("j=");
int j=int.Parse(Console.ReadLine()!);

printIJ(Array2,i,j);


*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.WriteLine ("Введите количество строк: ");
int rows=int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите количество столбцов: ");
int columns=int.Parse(Console.ReadLine()!);

int [,] Array3= GetArray(rows,columns,0,9);
PrintArray(Array3);

Console.WriteLine ($"Среднее арифметическое каждого столбца: {JoinAndRound(GetArgColumn(Array3),';')}.");

string JoinAndRound (double [] arr,char razdel) // Сцепим строку красиво с округлением, String.Join так не умеет
{
    string result="";
    for (int i=0; i<arr.Length;i++){
        if (i!=arr.Length-1) result+=$"{arr[i]:F1}{razdel}";
        else result+=$"{arr[i]:F1}";
    }
    return result;

}

double[] GetArgColumn (int [,] arr) // Double, а иначе целочисленно будет
{
    double[] summOfCol = new double[arr.GetLength(1)]; // создадим массив длинной = кол-ву столбцов в основном массиве
    for (int j=0; j<arr.GetLength(1);j++) // Вначале столбцы, потом строки!
    {
        int tempSum=0; //сложим суда сумму по строкам в конкретном столбце
        for (int i=0;i<arr.GetLength(0);i++)
        {
          tempSum+=arr[i,j];
        }
        summOfCol[j]=Convert.ToDouble(tempSum)/Convert.ToDouble(arr.GetLength(0)); // Можно было поделить на i - на выходе оно максимально, но так понятнее
        
    }
    return summOfCol;
}




void printIJ (int [,] arr, int i, int j)
{
    if (i<arr.GetLength(0) && j<arr.GetLength(1)) Console.WriteLine ($" Элемент с индексом ({i},{j})={arr[i,j]}");
    else Console.WriteLine ($"Элемента с индексом ({i},{j}) нет");
}



int [,] GetArray (int m, int n, int MinValue, int MaxValue)
{
    int [,] result=new int [m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0;j<n;j++)
        {
            result[i,j]=new Random().Next(MinValue,MaxValue+1);
        }
    }
    return result;
}

void PrintArray (int [,] arr)
{
 for (int i=0; i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
           Console.Write ($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}