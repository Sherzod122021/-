// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

System.Console.WriteLine("Введите кординату x: ");
int x = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите кординату y: ");
int y = Convert.ToInt32(System.Console.ReadLine());

if ( x > 0 && y > 0)
    System.Console.WriteLine("Точка находиться в первой четверти :");

else if ( x < 0 && y > 0)
    System.Console.WriteLine("Точка находиться в второй четверти :");

 else if ( x < 0 && y < 0)
    System.Console.WriteLine("Точка находиться в третий четверти :");   

 else 
 System.Console.WriteLine("Точка находиться в четвёртой  четверти :");   


