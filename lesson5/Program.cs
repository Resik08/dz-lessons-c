
int[] GenerateArray(int size, int leftRange, int rightRange) {
    Random rand = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange);
    }
    return array;
}
double[] GenerateDoubleArray(int size, double leftRange, double rightRange) {
    Random rand = new Random();
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] =  Math.Round((rand.NextDouble() * (rightRange - leftRange) + leftRange),2);
       // rand.NextDouble()  генерирует случайное вещественное число от 0 до 1 (0.454543546436)
       //домножаем его на разност правого и левого ренжа получаем 0.454543546436 * 9 (при ренжах 1 и 9) и получаем 4,5
       // дальше просто прибавляекм левый ренж чтобы сдвинуть в желаймый диапозон
        
    }
    return array;
}
void PrintArray(int[] arr) {
    Console.WriteLine($"Сгенерирванный массив: [{string.Join(", ", arr)}]");
}
int CounterPositiveNummbers(int[] arr)
{
    int count = 0;
    foreach (int n in arr)
    {
        if (n % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

int SumOddPosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}
double SearchValue(double[] arr, bool max)
{
    double value = arr[0];
    foreach (var n in arr)
    {
        if (max ? n > value : n < value)
        {
            value = n;
        }
        
    }

    return value;
}



// ----------------------------------------------- //
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2*/

Console.WriteLine("Это 34 задача");
int[] array = GenerateArray(12, 1, 501);
PrintArray(array);
Console.WriteLine($"Четных элементов в массиве: {CounterPositiveNummbers(array)}");
Console.WriteLine(); 

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0*/

Console.WriteLine("Это 36 задача");
int[] array1 = GenerateArray(12, 1, 50);
PrintArray(array1);
Console.WriteLine($"Сумма элементов на нечетных позициях: {SumOddPosition(array1)}");
Console.WriteLine(); // просто отделил для красивого вывода

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

Console.WriteLine("Это 38 задача");
/*double[] array3 = {3.22, 4.2, 1.15, 77.15, 65.2}; */
double[] array3 = GenerateDoubleArray(12, 1, 10);
Console.WriteLine($"Предложенный массив: [{string.Join(" | ", array3)}]");
double maxValue = SearchValue(array3, max:true);
double minValue = SearchValue(array3, max:false);
Console.WriteLine($"Максимальный элемент: {maxValue}, минимальный: {minValue}, а разница между ними: {Math.Round((maxValue - minValue), 2)}");
Console.WriteLine(); 