// Задача 23 : Напишите програму ,которая принимает на вход число (A) и выдаёт сумму чисел от 1 до А!

int Sum(int number )
{
    int sum = 0;
    for(int i = 1; i <= number; i++)
    
        sum += i;
    return sum;    


}




System.Console.WriteLine("введите число : ");
int A = Convert.ToInt32(System.Console.ReadLine());
int sum = Sum(A);
System.Console.WriteLine(sum);