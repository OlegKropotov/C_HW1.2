// // 
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int number = new Random().Next(1,10000);
Console.WriteLine(number);

string number1=Convert.ToString(number);

if (number1.Length>2)
{
    Console.WriteLine(number1[2]);
}
else
{
    Console.WriteLine("There is no third digit");
}