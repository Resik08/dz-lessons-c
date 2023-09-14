int[] LeadNumbers(string text)
{
    Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}
void PrintArray(int[] arr) {
    Console.WriteLine($"И так ваши числа: {string.Join(", ", arr)}");
}

void CounterPositiveNumbers(int[] arr, out int count)
{
    count = 0;
    foreach (var n in arr)
    {
        if (n > 0) count++;
    }
}

int LeadNumber(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

void getData(out double[] lineB, out double[] lineK)
{
    lineB = new double[2];
    lineK = new double[2];
    double[] result = new double[2];
    int i = 0;
    while (i < 2)
    {
        for (int j = 0; j < 2; j++)
        {
            result[j] = LeadNumber($"Введите {(i == 0 ? "b" : "k")}{j + 1}");
        }
        if (i == 0) lineB = result[..];
        else lineK = result[..];
        i++;
    }
    
}

double[] FoundMatch(double[] B, double[] K)
{
    double[] match = new double[2];
    match[0] = Math.Round((B[1] - B[0]) / (K[0] - K[1]),2);
    match[1] = Math.Round((K[0] * match[0] + B[0]),2);
    return match;
}

bool Proverka(double[] B, double[] K)
{
    return B[0] == B[1] || K[0] == K[1];
}

/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Это первая задача");
int count;
int[] array = LeadNumbers("Введите любые числа через пробел, а я скажу сколько было положительных чисел");
PrintArray(array);
CounterPositiveNumbers(array, out count);
Console.WriteLine($"Колличество положительных чисел - {count}");
Console.WriteLine();

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
    
Console.WriteLine("Это вторая задача");
double[] lineB;
double[] lineK;
Console.WriteLine();
getData(out lineB, out lineK);
if (Proverka(lineB, lineK))
{
    Console.WriteLine("Точки одной или двух линий совпали, невозможно определить их направление"); 
}
else
{
    double[] result = FoundMatch(lineB, lineK);
    Console.WriteLine($"Координаты пересечения линий B и K: ({string.Join(", ", result)})");  
}



























