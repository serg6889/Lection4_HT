// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int GetSumDigit(int number)
{
    Console.WriteLine("Input number   ");
    string number = Console.ReadLine()!;
    int numlength = number.Length;
    int sumdigit = 0;
    for(int j = 0; j <numlength; j++)
    {
    sumdigit +=(number[j] - '0'); 
    }
    return sumdigit;
}

Console.WriteLine($"Sum of digits in number{number} = {sumdigit}");