// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

double a;
Console.WriteLine("Введите положительное число:");
if (double.TryParse(Console.ReadLine(), out a))
{
    if (a>=0)
    {
        for (int i=0; i<=a; i+=2)
        {
            Console.Write(i);
            if (i+2<=a) Console.Write(", ");
        }
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("Введено число меньше нуля.");
    }
}
else
{
    Console.WriteLine("Введено некорректное значение.");
}
