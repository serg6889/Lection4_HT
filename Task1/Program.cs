// цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

double GetRate(double numA, double numB)
{
    double result = 0;
    if(numB == 0) 
    {
        result = 1;
    }
    if(numB > 0) 
    {
        result = numA;
        for ( double i = 2; i<=numB; i++)
        {
            result = result * numA;
        }
    }
    return result;
}

  Console.Write("Enter number A: ");
  double numA = Convert.ToDouble(Console.ReadLine());
  Console.Write("Enter number B: ");
  double numB = Convert.ToDouble(Console.ReadLine());

  double getrate = GetRate(numA, numB);
  Console.Write("GetRate = " + getrate);
