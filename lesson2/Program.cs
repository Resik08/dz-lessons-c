/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Console.WriteLine("Это первая задача");
Console.WriteLine("Введите трехзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number1 > 99 && number1 < 1000 ? number1 % 100 / 10 : "Введено не трехзначное число");
Console.WriteLine();

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Это вторая задача");
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    while (number > 999)
    {
        number =  number / 10;
    }
    number = number % 10;
    Console.WriteLine($"третие число это - {number}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}
Console.WriteLine();

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Это третия задача");
Console.WriteLine("Введите цифру дня недели ");
int numberDayWeek = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numberDayWeek <= 7 ? numberDayWeek < 6 ? "Нет, это рабочий день" : "Да, это выходной день"   : "Дня с таким номером нет, их всего 7");
Console.WriteLine();