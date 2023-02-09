/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Enter number: ");
string number = Console.ReadLine();
int sum = 0;

for (int i = 0; i < number.Length; i++)
{
    sum +=(number[i]- '0');
}

Console.Write($"The sum of the digits of a number {number} -> {sum}");