/* 
Задача 13: 
Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();

Console.Write("Введите целое число: ");
String userInput = Console.ReadLine() ?? ""; 
int num = int.Parse(userInput);

if (num < 100)
{
    Console.WriteLine($"Третьего номера числа {num} нет");
}

if (num >= 100 && num < 999)
{
    int res = num % 10;
    Console.WriteLine($"Вывод третьего числа: {num} -> {res}");
}

if (num >= 1000 && num < 9999)
{
    int a1 = num % 100;
    int res = a1 / 10;
    Console.WriteLine($"Вывод третьего числа: {num} -> {res}");
}

if (num >= 10000 && num < 99999)
{
    int a1 = num % 1000;
    int res = a1 / 100;
    Console.WriteLine($"Вывод третьего числа: {num} -> {res}");
}

if (num >= 100000)
{
    Console.WriteLine("Ошибка ввода");
}
