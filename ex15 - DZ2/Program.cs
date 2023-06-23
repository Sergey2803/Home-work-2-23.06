/* 
Задача 15: 
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли 
этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.Write("Введите номер дня недели: ");
String userInput = Console.ReadLine() ?? "";
int a = int.Parse(userInput);
if (a <= 5)
{
    Console.WriteLine($"{a} день недели - рабочий день");
}
if (a > 5 && a <= 7)
{
    Console.WriteLine($"{a} день недели - выходной день");
}
if (a > 7)
{
    Console.WriteLine("Ошибка ввода");
}