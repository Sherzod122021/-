// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
System.Console.WriteLine("Введите число :");
int a = Convert.ToInt32(System.Console.ReadLine());

int len = NumberLen(a);
SumNumber(a,len);

int NumberLen (int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index ++;
        
    }
    return index;
}


void SumNumber (int n , int len )
{
    int sum = 0;
    for (int i = 1;i<= len;i++)
    {
         sum += n % 10 ;
         n /=10;
        
    }
    System.Console.WriteLine($"сумма цифр {sum}");
}






