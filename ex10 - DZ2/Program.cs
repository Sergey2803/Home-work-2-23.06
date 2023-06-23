/* 
Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

Console.Write("Введите трехзначное число: ");
String userInput = Console.ReadLine() ?? ""; 
int num = int.Parse(userInput);

int a2 = num % 100;
int res = a2 / 10;

Console.WriteLine($"Вывод второго числа: {num} -> {res}");