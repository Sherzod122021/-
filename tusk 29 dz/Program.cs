// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] randomArray = new int [8];
for (int i=0;i<randomArray.Length;i++)
{
    randomArray[i] = new Random().Next (0 , 9);
    System.Console.Write( '[' + string.Join (",",randomArray[i]) + ']');
}



// System.Console.WriteLine('[' + string.Join(",",array) + ']');



