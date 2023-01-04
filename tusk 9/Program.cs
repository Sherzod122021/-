// Напишите программу ,которая вводит случвйное число из отрезка от 10 ло 99 и показывает наиюольшую цифру числа!


int number = new Random().Next(10, 100);
System.Console.WriteLine("Введите случайное число "  + number);

int dijit1 = number/10;
int dijit2 = number%10;

if (dijit1 > dijit2 )

    System.Console.WriteLine($"Первая цифра {dijit1} больше второй {dijit2} ");

else

     System.Console.WriteLine($"Вторя цифра {dijit2}  больше первой  {dijit1}");

