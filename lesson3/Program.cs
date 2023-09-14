/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Это первая задача");
Console.WriteLine("Введите пятизначное число ");
string chislo = Console.ReadLine()!;
if (chislo.Length == 5 && int.Parse(chislo) > 0)
{
    int firstSymbol = 0;
    int lastSymbol = chislo.Length - 1;
    while (firstSymbol < lastSymbol)
    {
        if (chislo[firstSymbol] != chislo[lastSymbol])
        {
            Console.WriteLine("Число не является палиндромом");
            break;
        }
        firstSymbol++;
        lastSymbol--;
    }

    if (firstSymbol >= lastSymbol)
    {
        Console.WriteLine("Число является палиндромом");
    }

}
else
{
    Console.WriteLine("Введено не правильное число");
}
Console.WriteLine();
/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.WriteLine("Это вторая задача");
int[] pointOne = new int[3];
int[] pointTwo = new int[3];

string[] coordinateNames = { "x", "y", "z" };

for (int i = 0; i < 3; i++)
{
    for (int pointIndex = 0; pointIndex < 2; pointIndex++)
    {
        Console.WriteLine($"Введите {coordinateNames[i]} {pointIndex + 1}-й точки в трехмерном пространстве");
        
        if (pointIndex == 0)
        {
            pointOne[i] = int.Parse(Console.ReadLine()!);
        }
        else
        {
            pointTwo[i] = int.Parse(Console.ReadLine()!);
        }
    }
}
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(pointTwo[0] - pointOne[0], 2) + Math.Pow(pointTwo[1] - pointOne[1], 2) + Math.Pow(pointTwo[2] - pointOne[2], 2)), 2));
Console.WriteLine();
/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Это третия задача");
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);
for (int i = 0; i < number; i++)
{
    Console.Write($"{Math.Pow(i+1,3)}, ");
}
Console.WriteLine();