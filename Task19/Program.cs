// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000 % 10;
int n2 = n / 1000 % 10;
int m1 = n / 10 % 10;
int m2 = n % 10;
int k1 = n / 10000;
if (k1 < 1 || k1 > 9)
{
    Console.WriteLine("Введите пятизначное число!");
}
else if  (n1 == m2 && n2 == m1)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Нет! Это не палиндром");
}