// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

System.Console.WriteLine("Введите число: ");
int numb1 = Convert.ToInt32(System.Console.ReadLine());
if ( numb1 % 7 == 0 && numb1 % 23 == 0)
    System.Console.WriteLine("число кратное ");

else 
    System.Console.WriteLine("число не кратное");    
