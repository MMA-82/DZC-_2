﻿Console.Write("Введите номер четверти, диапазон которой хотите узнать: ");
int quarter = int.Parse(Console.ReadLine() ?? "0");

if(quarter <= 4)
{
    if(quarter > 0)
    {
        if(quarter == 1) Console.WriteLine("В первой четверти координаты точек (х, у) принимают занчения в диапазоне х>0, у>0");
        if(quarter == 2) Console.WriteLine("Во второй четверти координаты точек (х, у) принимают занчения в диапазоне х<0, у>0");
        if(quarter == 3) Console.WriteLine("В третьей четверти координаты точек (х, у) принимают занчения в диапазоне х<0, у<0");
        if(quarter == 4) Console.WriteLine("В четвертой четверти координаты точек (х, у) принимают занчения в диапазоне х>0, у<0");
    }
    else Console.WriteLine("Нет такой четверти!");
}
else Console.WriteLine("Нет такой четверти!");