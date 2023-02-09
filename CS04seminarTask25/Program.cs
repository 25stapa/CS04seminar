/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber(string message)
{
    int number = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out number) && number != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("You didn't enter a number, please try again ");
        }
    }
    return number;
}

int numberA = GetNumber("Enter number A: ");
int numberB = GetNumber("Enter number B: ");

double numberNatDegree = Math.Pow(numberA, numberB);

Console.WriteLine($"-> {numberNatDegree}");
