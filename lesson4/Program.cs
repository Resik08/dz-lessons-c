/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int ReadNumber(string text) {
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
double GoToLevel(int number, int rate)
{ 
    return Math.Pow(number, rate);
}
Console.WriteLine("Это первая задача");
Console.WriteLine($"Ответ: {GoToLevel(ReadNumber("Введите число"),  ReadNumber("Введите степень числа"))}");

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
int SumNumbers(int number)
{
    int sum = 0;
    
    while (number > 0)
    {
        sum += number % 10; 
        number /= 10;
        Console.WriteLine(number);
    }
    
    return sum;
}

Console.WriteLine("Это вторая задача");

Console.WriteLine($"Ответ: {SumNumbers(ReadNumber("Введите число"))}");



/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] GenerateArray()
{
    int[] arr = new int[8];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 100);
    }

    return arr;
}

Console.WriteLine("Это третия задача");
Console.WriteLine($"[{string.Join(", ", GenerateArray())}]");