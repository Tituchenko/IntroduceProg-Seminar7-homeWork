//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

//m = 3, n = 4.

//1 7 -2 -85

//1 -3 8 -9

//8 7 -7 9

Console.WriteLine ("Введите количество строк: ");
int rows=int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите количество столбцов: ");
int columns=int.Parse(Console.ReadLine()!);

int [,] Array= GetArray(rows,columns,-9,9);
PrintArray(Array);




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