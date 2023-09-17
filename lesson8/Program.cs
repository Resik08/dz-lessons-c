int LeadNumber (string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

int[,] FillMatrix (int row, int col, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[,] tempMatrix = new int[row, col];

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }

}

void SortArray(int[,] arr) {
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < arr.GetLength(1) - j - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
    }
}

int ArrayStringSumMin(int[,] arr) {
    int result = 0;
    int maxValue = 0;
    for (int i = 0;  i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }

        if (i == 0 || sum < maxValue)
        {
            maxValue = sum;
            result = i;
        }
    
    }
    return result;
}

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int colNew, int rowNew)
{
    int[,] result = new int[rowNew, colNew];
    for (int k = 0; k < colNew; k++)
    {
        for (int j = 0; j < rowNew; j++)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++) 
            {
                result[j, k] += matrix1[j, i] * matrix2[i, k];
            }
        }
    }

    Console.WriteLine("Ответ: ");
    PrintMatrix(result);
    Console.WriteLine();
}

int[,,] ThreeDMatrix (int row, int col, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[,,] tempMatrix = new int[row, col, 2];

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < tempMatrix.GetLength(2); k++)
            {
                tempMatrix[i, j, k] = rand.Next(leftRange, rightRange);
            }
        }
    }
    return tempMatrix;
}

void ThreeDMatrixPrint(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i, j, k]  + $"({i},{j},{k})" + "\t");
            }
            Console.WriteLine();
        }

        
    }
}

int[,] FillTheSpiral (int[,] arr) {
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);

    int value = 1;
    int left = 0, right = cols - 1, top = 0, bottom = rows - 1;
 
    while (left <= right && top <= bottom) 
    {
        for (int i = left; i <= right; i++)
        {
            arr[top, i] = value;
            value++;
        }
        top++;
    
        for (int i = top; i <= bottom; i++)
        {
            arr[i, right] = value;
            value++;
        }
        right--;
    
        for (int i = right; i >= left; i--)
        {
            arr[bottom, i] = value;
            value++;
        }
        bottom--;

  
        for (int i = bottom; i >= top; i--)
        {
            arr[i, left] = value;
            value++;
        }
        left++;
    }

    return arr;

}


//---------------------------------------------//

/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.WriteLine("Это первая задача");
Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
int rows = LeadNumber("Введите колличество строк ");
int cols = LeadNumber("Введите колличество стобцов ");
int[,] matrix = FillMatrix(rows, cols, 1, 10);
PrintMatrix(matrix);
SortArray(matrix);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.WriteLine("Это вторая задача");
Console.WriteLine("Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов");
int rows1 = LeadNumber("Введите колличество строк ");
int cols1 = LeadNumber("Введите колличество стобцов ");
int[,] matrix1 = FillMatrix(rows1, cols1, 1, 10);
PrintMatrix(matrix1);
int result = ArrayStringSumMin(matrix1);
Console.WriteLine();
Console.WriteLine($"Минимальное суммарное значение элементов в {result+1} строке массива");
Console.WriteLine();

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

void StartTask()
{
    Console.WriteLine("Это третия задача");
    Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц");
    int rowsA = LeadNumber("Введите колличество строк ");
    int colsA = LeadNumber("Введите колличество стобцов ");
    int[,] matrixA = FillMatrix(rowsA, colsA, 1, 10);
    PrintMatrix(matrixA);
    Console.WriteLine();
    Console.WriteLine("Матрица для перемножения ");
    int rowsB = LeadNumber("Введите колличество строк ");
    int colsB = LeadNumber("Введите колличество стобцов ");
    int[,] matrixB = FillMatrix(rowsB, colsB, 1, 10);
    PrintMatrix(matrixB);
    Console.WriteLine();
    if (rowsA == colsB && colsA == rowsB)
    {
     MultiplyMatrix(
           matrixA.GetLength(1) >= matrixB.GetLength(1) ? matrixA: matrixB,
           matrixA.GetLength(1) <= matrixB.GetLength(1) ? matrixA: matrixB, 
           colsB < colsA ? colsB : colsA,
           rowsA < rowsB ? rowsA : rowsB);
      
    }
    else
    {
        Console.WriteLine("Данные матрицы нельзя перемножить");
        Console.WriteLine("Попробуем еще раз");
        StartTask();
    }
}


StartTask();

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.WriteLine("Это четвертая задача");
Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу," +
                  " которая будет построчно выводить массив, добавляя индексы каждого элемента.Массив" +
                  " размером 2 x 2 x 2");
int[,,] matrixThreeD = ThreeDMatrix(2, 2, 10, 100);
ThreeDMatrixPrint(matrixThreeD); 
Console.WriteLine();



/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.WriteLine("Это пятая задача");
Console.WriteLine("Напишите программу, которая заполнит спирально массив");
int rows5 = LeadNumber("Введите колличество строк ");
int cols5 = LeadNumber("Введите колличество стобцов ");
int[,] matrix5 = FillMatrix(rows5, cols5, 0, 1);
int[,] spiral = FillTheSpiral(matrix5);
PrintMatrix(matrix5);