// цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

int GetRate(double numA, double numB)
{
  double result = 1;
  for(int j=1; j <= numB; j++)
  {
    double result = Math.Pow(numA, numB);
  }
  return result;
}


  Console.Write("Enter number A: ");
  double numA = Convert.ToDouble(Console.ReadLine());
  Console.Write("Enter number B: ");
  double numB = Convert.ToDouble(Console.ReadLine());

  int getrate = GetRate(numA, numB);
  Console.Write("GetRate = " + getrate);
