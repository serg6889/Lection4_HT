// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Input number   ");
string number = Console.ReadLine()!;
int numlength = number.Length;
int sum = 0;
for(int j = 0; j <numlength; j++)
{
sum +=(number[j] - '0'); 
}
Console.WriteLine($"Sum of digits in number{number} = {sum}");