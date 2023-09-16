T LeadNumber<T>(string text)
{
    Console.Write(text);
    string input = Console.ReadLine()!;
    
    return typeof(T) switch
    {
        Type t when t == typeof(int) => (T)(object)int.Parse(input),
        Type t when t == typeof(string) => (T)(object)input,
        _ => throw new ArgumentException("Unsupported type T"),
    };
}

T[,] FillMatrix<T>(int row, int col, T leftRange, T rightRange)
{
    Random rand = new Random();
    T[,] tempMatrix = new T[row, col];

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            if (typeof(T) == typeof(int))
            {
                tempMatrix[i, j] = (T)(object)rand.Next((int)(object)leftRange!, (int)(object)rightRange!);
            }
            else if (typeof(T) == typeof(double))
            {
                tempMatrix[i, j] = (T)(object)Math.Round(rand.NextDouble() *
                    (((double)(object)rightRange!) - ((double)(object)leftRange!)) + ((double)(object)leftRange!), 1);
            }
        }
    }

    return tempMatrix;
}


void PrintMatrix<T>(T[,] tempMatrix)
{
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            Console.Write(tempMatrix[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

void Separate(string num, out int rightNumber, out int leftNumber)
{
    rightNumber = int.Parse(num[1].ToString());
    leftNumber =  int.Parse(num[0].ToString());
}

bool isValid(string num)
{
    return num.Length == 2;
}

int FoundNumber(int[,] tempMatrix, int right, int left)
{
    int result = int.MinValue;
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            if (i == left && j == right) result = tempMatrix[i, j];
        }
    }

    return result;
}

int[] CountNumbersInCol(int[,] matrix ,int col)
{
    int[] result = new int[col];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result[i] += matrix[j, i];
        }

        result[i] =  result[i] / matrix.GetLength(0);
    }

    return result;
}
/////------------------------------------------------/////
/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.WriteLine("Это первая задача");
int rows = LeadNumber<int>("Введите колличество строк ");
int cols = LeadNumber<int>("Введите колличество стобцов ");
double[,] matrix = FillMatrix<double>(rows, cols, 1, 100);
PrintMatrix<double>(matrix);
Console.WriteLine();


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

    Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.WriteLine("Это вторая задача");
int rightNumber;
int leftNumber;
int[,] matrix1 = FillMatrix<int>(3, 4, 1, 100);
PrintMatrix<int>(matrix1);
string number = LeadNumber<string>("Введите двузначное число ");
if (isValid(number))
{
    Separate(number, out rightNumber, out leftNumber);
    int result = FoundNumber(matrix1, rightNumber, leftNumber);
    Console.WriteLine(result == int.MinValue ? "Такого элемента нет" : $"Элемент на позиции {rightNumber}, {leftNumber} это {result}");
}
else Console.WriteLine("Введено не двузначное число");  
Console.WriteLine();

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Это третия задача");
int[,] matrix2 = FillMatrix<int>(3, 4, 1, 100);
int[] result20 = CountNumbersInCol(matrix2, 4);
PrintMatrix<int>(matrix2);
Console.WriteLine("Ответ:");
Console.WriteLine(string.Join("\t", result20));