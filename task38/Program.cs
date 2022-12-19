Console.WriteLine("введите количество чисел в массиве");
int N = Convert.ToInt32(Console.ReadLine());
double [] array = new double [N];
for (int i = 0; i<N; i++)
{
    array [i] = new Random().NextDouble()*100;
    Console.Write($"{array[i]} ");
}
double max=array[0];
double min=array[0];
for (int j=1;j<N;j++)
{
    if (array[j]>max) max = array[j];
    if (array[j]<min) min = array[j];
}
Console.WriteLine();
Console.WriteLine($"максимальный элемент {max}, минимальный элемент {min}");
double result = max-min;
Console.WriteLine($"разница {result}");