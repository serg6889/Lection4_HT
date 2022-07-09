// программа задаёт массив из 8 элементов и выводит их на экран
int[] array = new int[8] ;
void FillArray (int[] massive) 
{
       for (int j=0; j < massive.Length; j++)
      { 
	  massive[j] = new Random().Next(9);
	
      }

}
void ShowMass (int[] massive) 
{
foreach(var item in massive)
{
Console.WriteLine(item + "");
}
}
