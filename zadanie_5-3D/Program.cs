Console.Write("Введите координату точки A, х: ");
int xA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите координату точки A, у: ");
int yA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите координату точки A, z: ");
int zA = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите координату точки B, х: ");
int xB = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите координату точки B, у: ");
int yB = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите координату точки B, z: ");
int zB = int.Parse(Console.ReadLine() ?? "0");

double result = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
Console.WriteLine("Расстояние между точками равно: {0:0.000}", result); 



