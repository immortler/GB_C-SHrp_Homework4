/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16   */

double GetNumber(string message)
{
    bool isCorrect = false;
    double result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (double.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Error: wrong entered data.");
        }
    }
    return result;
}

void GetPowBOfA(double a, double b)
{
    double resultOfPow = 1;
    double moduleOfPow = b;
    if (b < 0)
    {
        moduleOfPow = -1 * moduleOfPow;
    }
    else if (b == 0)
    {
        if (a == b)
        {
            Console.WriteLine($"Mathematicians say that {a}, like any other number, to the power of {b} is equal to 1.");
            return;
        }
        else
            Console.WriteLine($"Any number (including {a}) to the power of {b} is equal 1.");
        return;
    }

    resultOfPow = 1;
    for (int i = 1; i <= moduleOfPow; i++)
    {
        resultOfPow = a * resultOfPow;
    }
    if (b < 0)
    {
        resultOfPow = 1 / resultOfPow;
    }
    Console.WriteLine($"Number A ({a}) to the power of B ({b}) is {resultOfPow}.");
}

double a = GetNumber("Enter number A:");
double b = GetNumber("Enter number B:");
GetPowBOfA(a, b);