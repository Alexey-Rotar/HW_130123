// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Проще было бы с использованием массива, но это еще не проходили :)
// Также добавлена проверка корректности введенного значения.

double a;
double b;
double c;
Console.WriteLine("Введите три числа:");
if ((double.TryParse(Console.ReadLine(), out a)) & (double.TryParse(Console.ReadLine(), out b)) & (double.TryParse(Console.ReadLine(), out c)))
{
    if ((a>b)&(a>c)) 
        Console.WriteLine("Максимальное: "+a+".");
    else if ((b>a)&(b>c))
        Console.WriteLine("Максимальное: "+b+".");    
    else if ((c>a)&(c>b))
        Console.WriteLine("Максимальное: "+c+".");
    else if ((a==b)|(a==c)|(b==c))
        Console.WriteLine("Максимального из трёх нет.");
}
else
{
    Console.WriteLine("Введено некорректное значение.");
}

// Без проверки корректности
/*
Console.WriteLine("Введите три числа:");
double a=Convert.ToDouble(Console.ReadLine());
double b=Convert.ToDouble(Console.ReadLine());
double c=Convert.ToDouble(Console.ReadLine());
if ((a>b)&(a>c)) 
    Console.WriteLine("Максимальное: "+a+".");
else if ((b>a)&(b>c))
    Console.WriteLine("Максимальное: "+b+".");    
else if ((c>a)&(c>b))
    Console.WriteLine("Максимальное: "+c+".");
else if ((a==b)|(a==c)|(b==c))
    Console.WriteLine("Максимального из трёх нет.");
*/