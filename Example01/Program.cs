// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());


    if (a < 100 || a >= 1000)
    {
    Console.Write("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;
    }


Console.WriteLine($"Введенное число: {a}");

int b = (a / 10) % 10;

Console.WriteLine("Вторая цифра: ");




/*Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);*/