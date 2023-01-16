// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.Write("Введите трёхзначное число: ");
int numb1 = Convert.ToInt32(System.Console.ReadLine());

if (numb1 > 99 ) 
   

 System.Console.WriteLine(numb1.ToString()[2]);    
  


else 
    System.Console.WriteLine("Третьей цифры нет !");