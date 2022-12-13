/* Задача 27: 

Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
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

void SumOfDigits(int number)
{
    int tmp = number;
    int minus = 1;
    if (number ==0)
    {
        Console.WriteLine("You entered 0, there is 1 digit and nothing to sum up.");
        return;
    }    
    else if (number < 0)
    {
        minus = -1*minus;
    }
    
    int result = 0;
    int countOfDigits = 0;
    tmp = number*minus;
    while (tmp>0)
    {
        tmp = tmp/10;
        countOfDigits++;
    }
    tmp = number*minus;
    int[] arrayWithDigsOfNumber = new int[countOfDigits];
    for (int i = 0; i < arrayWithDigsOfNumber.Length; i++)
    {
        int tenInPower = Convert.ToInt32(Math.Pow(10, (countOfDigits-1)-i));
        if (tenInPower > 1)
        {
        arrayWithDigsOfNumber[i] = tmp / tenInPower;
        tmp = tmp - (arrayWithDigsOfNumber[i]*tenInPower);
        }        
        else
        {
            arrayWithDigsOfNumber[i] = number*minus % 10;
        }
    }
    Console.Write($"There is {countOfDigits} digits in {number}, these digits are ");
    for (int i = 0; i < arrayWithDigsOfNumber.Length; i++)
    {
        Console.Write($"{arrayWithDigsOfNumber[i]}, ");
        result =  result + arrayWithDigsOfNumber[i];  
    }
    Console.Write($"and sum of this digits is {result}");
    return;
}

int number = GetNumber("Enter integer number:");
SumOfDigits(number);