Console.WriteLine("Введите пятизначное число");
string five = Console.ReadLine() ?? "0";
int N = five.Length;
if(N > 4)
{
    if(N < 6)
    {
        if(five[0] == five[4])
        {
            if(five[1] == five[3]) Console.WriteLine("Введенное число является палиндромом");
            else Console.WriteLine("Введенное число не является палиндромом");
        }
        else Console.WriteLine("Введенное число не является палиндромом");
    }
    else Console.WriteLine("Введенное число не пятизначное!!!");
}
else Console.WriteLine("Введенное число не пятизначное!!!");        
