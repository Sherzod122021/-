// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите цифру от 1 до 7: ");
Convert.ToInt32(System.Console.ReadLine());

int dayNumber = 6;
int dayNumber1 = 7;


if (dayNumber == 6  || dayNumber1 == 7)
    System.Console.WriteLine("ДА");
    
else if (dayNumber <1 || dayNumber1 > 7)    
    System.Console.WriteLine("Не день недели");

else
        System.Console.WriteLine("нет");    
























