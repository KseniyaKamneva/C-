// Задача 34

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
RandomArray(nums);
Console.WriteLine("Массив: ");
Print(nums);
int count = 0;

for (int i = 0; i < nums.Length; i++)
    if (nums[i] % 2 == 0)
    count++;

Console.WriteLine($"Из {nums.Length} чисел {count} чётных");

void RandomArray(int[] nums)
{
    for(int i = 0; i < nums.Length; i++)
    {
        nums[i] = new Random().Next(100,1000);
    }
}

void Print(int[] nums)
{
    Console.Write("[ ");
    for(int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

//Задача 36

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
RandomArray(nums);
Console.WriteLine("Массив: ");
Print(nums);
int sum = 0;

for (int i = 0; i < nums.Length; i+= 2)
    sum = sum + nums[i];
Console.WriteLine($"Cумма элементов, находящихся на нечётных позициях, равна {sum}");

void RandomArray(int[] nums)
{
    for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = new Random().Next(-999, 1000);
        }
}

void Print(int[] nums)
{
    Console.Write("[ ");
    for(int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

//Задача 38

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] nums = new double[size];
RandomArray(nums);
Console.WriteLine("Массив: ");
Print(nums);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > max)
        {
            max = nums[i];
        }
    if (nums[i] < min)
        {
            min = nums[i];
        }
}

Console.WriteLine($"Разница максимального и минимального значений равна {max - min}");

void RandomArray(double[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = Convert.ToDouble(new Random().NextDouble()) * 100;
    }
}

void Print(double[] nums)
{
    Console.Write("[ ");
    for(int i = 0; i < nums.Length; i++)
    {
        Console.Write(Math.Round(nums[i], 2) + "  ");
    }
    Console.Write("]");
    Console.WriteLine();
}

//Задача 37

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
int[] res = new int[size/2];
RandomArray(nums);
Console.WriteLine("Массив: ");
//PrintNums(nums);
//PrintRes(nums, res);
Console.Write(nums.ToString());

void RandomArray(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = new Random().Next(0,10);
    }
}

void PrintNums(int[] nums)
{
    Console.Write("[ ");
    for(int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void PrintRes(int[] nums, int[] res)
{
    int len = nums.Length;
    int i = 0;
    Console.Write("[ ");
    for (int j = 0; j < len / 2; j++)
    {
        res[j] = nums[i] * nums[len - i - 1];
        i++;
        Console.Write(res[j] + " ");
    }
    if (len % 2 == 0)
    {
        Console.Write("]");
    }
    else
    {
        Console.Write(nums[i] + "]");
    }
    Console.WriteLine();
}
