int[]Printarray(int number)
{
int [] array = new int [number];
for (int i = 0; i<array.Length; i++)
{
    array [i] = new Random().Next(0,1000);
    Console.Write($"{array[i]} ");
    }
    return array;
 }
Console.WriteLine("введите количество цифр в массиве");
 int N = Convert.ToInt32(Console.ReadLine());
 int [] array = Printarray(N);
 int Sum = 0;
for (int i = 0; i<array.Length; i++)
  {
   if (i%2!=0)
   Sum = Sum+array[i];
 }
 Console.WriteLine();
 Console.WriteLine(Sum);