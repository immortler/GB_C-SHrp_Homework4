/* Задача 29: 

Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

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

double[] FillingArray()
{
    double[] array = new double[8];
    for (int i = 0; i < array.Length; i++)
    {
        double number = GetNumber("Enter number for input to array:");
        array[i] = number;
    }


    Console.Write("Your array: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}].");
        }
    }
    return array;
}
double[] outArray = new double[8];
outArray = FillingArray();
