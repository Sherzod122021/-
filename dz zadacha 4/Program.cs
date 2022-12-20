
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите три числа ");

int min = Convert.ToInt32(System.Console.ReadLine());
int max = Convert.ToInt32(System.Console.ReadLine());
int max_2 = Convert.ToInt32(System.Console.ReadLine());

if (min > max && min > max_2)
    System.Console.WriteLine("Максимальное число " + min);

else if (max > min && max > max_2)
    System.Console.WriteLine("Максимальное число " + max);

else     System.Console.WriteLine("Максимальное число " + max_2);
    

