// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Input number   ");
string number = Console.ReadLine()!;

int GetSumDigit(string number)
{
    
    int numlength = number.Length;
    int sumdigit = 0;
    for(int j = 0; j <numlength; j++)
    {
    sumdigit +=(number[j] - '0'); 
    }
    return sumdigit;
}

Console.WriteLine($"Sum of digits in number{number} = {sumdigit}");

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
/*