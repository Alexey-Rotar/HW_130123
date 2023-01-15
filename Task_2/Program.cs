// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Наверное, на данном этапе это не обязательно, но захотелось сделать проверку корректности введенного значения.

double a;
double b;
Console.WriteLine("Введите два числа:");
if ((double.TryParse(Console.ReadLine(), out a)) & (double.TryParse(Console.ReadLine(), out b)))
{
    if (a>b) 
        Console.WriteLine("Наибольшее: "+a+"; наименьшее: "+b+".");
    else if (b>a)
        Console.WriteLine("Наибольшее: "+b+"; наименьшее: "+a+".");
    else if (a==b)
        Console.WriteLine("Числа равны.");
}
else
{
    Console.WriteLine("Введено некорректное значение.");
}
