Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine() ?? "0");

if(a == b*b) Console.WriteLine("Первое число является квадратом второго числа");
else Console.WriteLine("Первое число не является квадратом второго числа");

if(b == a*a) Console.WriteLine("Второе число является квадратом первого числа");
else Console.WriteLine("Второе число не является квадратом первого числа");