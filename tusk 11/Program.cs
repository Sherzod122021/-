// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
//  918 -> 98

 System.Console.WriteLine("Введите число ");
int rand = Convert.ToInt32(System.Console.ReadLine());

int dijit1 = rand / 100;
int dijit2 = rand % 10;

int ansver = dijit1* 10  + dijit2;
System.Console.WriteLine($"{rand} = {ansver}");