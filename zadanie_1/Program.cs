Console.WriteLine("Введите число - номер дня недели");
int daynumber = int.Parse(Console.ReadLine() ?? "0");
if(daynumber < 8)
{
    if(daynumber > 0)
    {
        if(daynumber == 1) Console.WriteLine("Понедельник будний день");
        if(daynumber == 2) Console.WriteLine("Вторник будний день");
        if(daynumber == 3) Console.WriteLine("Среда будний день");
        if(daynumber == 4) Console.WriteLine("Четверг будний день");
        if(daynumber == 5) Console.WriteLine("Пятница будний день");
        if(daynumber == 6) Console.WriteLine("Суббота выходной!!!");
        if(daynumber == 7) Console.WriteLine("Воскресенье выходной!!!");
    }
    else Console.WriteLine("Нет такого номера дня недели!");
}
else Console.WriteLine("Нет такого номера дня недели!");