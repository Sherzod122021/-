// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

 System.Console.WriteLine("Введите трёхзначное число: ");
 int num1 = Convert.ToInt32(System.Console.ReadLine());
 num1 = num1 / 10;
 num1 = num1 % 10;
 System.Console.WriteLine(num1);
