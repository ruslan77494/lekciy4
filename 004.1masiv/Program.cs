Console.WriteLine("Введите размерность массива:");
int demension = int.Parse(Console.ReadLine());
Random rnd = new Random();
int[] arr = new int[demension];

for (int i = 0; i < demension; i++)
{
arr[i] = rnd.Next(0,2);
}

var result = string.Join(", ", arr);
Console.WriteLine(result);
