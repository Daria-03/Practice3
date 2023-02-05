// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
class Palindrom
{
    static bool programm(int n)
    {
        int b = 0, nn = n;
        while (n > 0)
        {
            b = b * 10 + n % 10;
            n = n / 10;
        }
        return b == nn;
    }
    static void Main()
    {
        int a;
        Console.Write("Введите любое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        if (programm(a))
            Console.WriteLine("Палиндром");
        else
            Console.WriteLine("Не палиндром");
    }
}