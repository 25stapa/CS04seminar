/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/


Console.Write("Enter 8numbers separated by commas: ");
string[] strArray = Console.ReadLine().Split(',');

int[] result = new int[strArray.Length];
for (int i = 0; i < result.Length; i++)
{
result[i] = int.Parse(strArray[i]);
}

System.Console.WriteLine();
Console.WriteLine(string.Join(',', result));
System.Console.WriteLine();
