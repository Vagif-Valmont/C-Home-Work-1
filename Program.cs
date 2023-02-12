// ДЗ1 Задача 4 программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

 Console.WriteLine("Ввидите 1 число");
    int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ввидите 2 число");
    int b = int.Parse(Console.ReadLine());
Console.WriteLine("Ввидите 3 число");
    int c = int.Parse(Console.ReadLine());
        var Max = a;
        if (Max < b)
    {
            Max = b;
        if (Max < c)
    {
            Max = c;
Console.WriteLine("Max = " + Max);
    }   
    else
    {
        Console.WriteLine("Max = " + Max);
    }
    } 
    else if (Max < c) 
{
    Max = c; 
Console.WriteLine("Max = " + Max);
}
    else 
Console.WriteLine("Max = " + Max);

// Семинар 2 Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

 int num = new Random().Next(100, 1000);
 {
Console.WriteLine(num);
int a = num / 10 % 10;
Console.WriteLine(a);
}

// Семинар 1 Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
if(a % 2 == 0)
{
   Console.WriteLine("Число чётное"); 
}
else
{
    Console.WriteLine("Число нечётное"); 
}

// Семинар 1 Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("your number = ");
int N = int.Parse(Console.ReadLine());
var i = 1;
while ( i <= N)
{
    if (i % 2 == 0)
    {   
    System.Console.WriteLine(i + ", ");
    i++;
    }
    else
    {
        i++;
    }
}
