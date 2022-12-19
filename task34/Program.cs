Console.WriteLine("введите количество цифр в массиве");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
int count = 0;
for (int i = 0; i<N; i++)
{
    array [i] = new Random().Next(99,1000);
    Console.Write($"{array[i]} ");
    if (array[i]%2 == 0)
    count++;
}
Console.WriteLine();
Console.WriteLine($"четных чисел {count}");
