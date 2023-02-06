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

