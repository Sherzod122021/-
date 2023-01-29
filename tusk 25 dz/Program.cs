// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

System.Console.WriteLine("Введите два числа :");

int numberA= Convert.ToInt32(System.Console.ReadLine()); 
int numberB= Convert.ToInt32(System.Console.ReadLine()); 
Todegree(numberA,numberB);


void Todegree (int a ,int b)
{
    int result = 1;
    for (int i=1;i <= b;i++)
    result = result * a;
    System.Console.WriteLine(a + " в степени " + b + " = " + result);

}






