// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

System.Console.WriteLine("Введите два числа: ");
int numb1 = Convert.ToInt32(System.Console.ReadLine());
int numb2 = Convert.ToInt32(System.Console.ReadLine());

if (numb1 * numb1 == numb2 )
    System.Console.WriteLine("да являеться");
else if (numb2 * numb2 == numb1)
    System.Console.WriteLine("также являеться");    
else   System.Console.WriteLine("не Являеться");    