int LeadNumber (string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

int SumNumbers(int numberA, int numberB)
{
    if (numberA > numberB) return 0;
    return numberA + SumNumbers(numberA + 1, numberB);
}

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}




/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Это первая задача");
int M = LeadNumber("Введите начальное число ");
int N = LeadNumber("Введите конечное число ");
if (M > N)
{
    Console.WriteLine("Введены некорректные данные");
    return;
}
int sum = SumNumbers(M, N);
System.Console.WriteLine($"Ответ: {sum}");



System.Console.WriteLine(); //
/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.WriteLine("Это вторая задача");
int m = LeadNumber("Введите начальное число ");
int n = LeadNumber("Введите конечное число ");
if (m < 0 || n < 0)
{
    Console.WriteLine("Введены некорректные данные");
    return;
}
Console.WriteLine($"Ответ: {Ackermann(m, n)}");
