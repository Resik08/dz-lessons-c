// 1 задача
Console.WriteLine("Это первая задача");
Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA < numberB)
{
    Console.WriteLine($"{numberB} - является максимальным числом, а {numberA} - минимальным числом");
}
else if (numberA == numberB)
{
    Console.WriteLine("В результате выяснено что 2 числа равны, нет максимального и минимального");
}
else
{
    Console.WriteLine($"{numberA} - является максимальным числом, а {numberB} - минимальным числом");
}
Console.WriteLine();

// 2 задача
Console.WriteLine("Это вторая задача");
int[] numbers = new int[3];
int max = numbers[0];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Введите {i+1} число");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine("Это максимальное число - " + max);
Console.WriteLine();

// 3 задача
Console.WriteLine("Это третия задача");
Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number1 % 2 == 0 ? "Да, число четное" : "Нет, число не четное");
Console.WriteLine();
// 4 задача
Console.WriteLine("Это четвертая задача");
Console.Write("Введите число! ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 1)
{
    Console.WriteLine("Введите число больше 1");
}
else
{
    for (int i = 2; i <= number; i += 2)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine();


