// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

double a;
Console.WriteLine("Введите число:");
if (double.TryParse(Console.ReadLine(), out a))
{
    if (a%2==0)
        Console.WriteLine("Число чётное.");
    else 
        Console.WriteLine("Число нечётное.");
}
else
{
    Console.WriteLine("Введено некорректное значение.");
}

// Без проверки корректности
/*
Console.WriteLine("Введите число:");
double a=Convert.ToDouble(Console.ReadLine());
if (a%2==0)
    Console.WriteLine("Число чётное.");
else 
    Console.WriteLine("Число нечётное.");
*/