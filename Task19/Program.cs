// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Enter 5 digit number");
int number5 = Convert.ToInt32(Console.ReadLine());
string num5=Convert.ToString(number5);
if (num5[0]==num5[4]&&num5[1]==num5[3])
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}