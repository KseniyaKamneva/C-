//Задача 41

Console.Write("Введите элементы массива через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество элементов больше нуля равно: {count}");

Задача 43

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

if ((k1 - k2) != 0)
{ 
    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;
    x = Math.Round(x, 2);
    y = Math.Round(y, 2);
    Console.WriteLine($"Пересечение находится в точке: ({x};{y})");
}
else
{
    Console.Write("Точек пересечения не найдено.");
}

//Задача * Напишите программу, котрая находит подмножество данного множества чисел такое, что сумма его элементов равна заданному числу
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
RandomArray(nums);
Console.WriteLine("Массив: ");
Print(nums);
Console.WriteLine("Задайте число: ");
int sum = Convert.ToInt32(Console.ReadLine());
PrintSearch(nums, sum);

void RandomArray(int[] nums)
{
    for(int i = 0; i < nums.Length; i++)
    {
        nums[i] = new Random().Next(1,10);
    }
}

void Print(int[] nums)
{
    Console.Write("[ ");
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void PrintSearch(int[] nums, int sum)
{
    int[] Search = new int[nums.Length];
    int j = 0;
    int presum = 0;

    for (int i = 0; i < nums.Length; i++) 
    {
        if (presum < sum)
        {
            presum = presum + nums[i];
            Search[j] = nums[i];
            j++;
        }
        if (presum > sum)
        {
            presum = presum - nums[i-1];
            j--;
        }
    }
    if (presum == sum)
    {
        Console.Write("[ ");
        for (int k = 0; k < j; k++)
        {
            Console.Write(Search[k] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
    else
    {
        Console.Write("Такого подмножества нет.");
    } 
}