// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
System.Console.WriteLine("Ввудите трёхзначное число! ");
int a = Convert.ToInt32(System.Console.ReadLine());

if (a >= 100 && a < 100)
    Console.WriteLine("Последняя цифра ");
    Console.WriteLine(a%10);
else
{
    Console.WriteLine("Введено не 3-значное число!");
}    