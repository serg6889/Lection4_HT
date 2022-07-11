// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
using System;
Console.WriteLine("Input number   ");
string number = Console.ReadLine()!;

int GetSumDigit(string number)
{
    int numlength = number.Length;
    int sumdigit = 0;
    for(int j = 0; j <numlength; j++)
    {
    sumdigit += int.Parse(number[j].ToString()); 

    }
    return sumdigit;
}

Console.WriteLine($"Sum of digits in number {number} = {GetSumDigit(number)}");

/*

Console.WriteLine("Input number   ");
string number = Console.ReadLine()!;
int numlength = number.Length;
int sumdigit = 0;
for(int j = 0; j <numlength; j++)
{
sumdigit +=(number[j] - '0'); 
}
Console.WriteLine($"Sum of digits in number{number} = {sumdigit}");
*/