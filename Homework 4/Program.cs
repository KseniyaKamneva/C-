// Задача 25

int Involution(int A, int B)
{
    int result = 1;
    for (int i =1 ; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int Involution = Involution(A, B);
Console.WriteLine("Решение: " + Involution);


// Задача 27

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum(int N)
{ 
    int count = Convert.ToString(N).Length;
    int adv = 0;
    int res = 0;

    for (int i = 0; i < count; i++)
    {
        adv = N - N % 10;
        res = res + (N - adv);
        N = N / 10;
    }
   return res;
  }

int sum = Sum(N);
Console.WriteLine("Сумма цифр в числе равна " + sum);

// Задача 29

Console.Write("Введите количество чисел в массиве : ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];

Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
   array[i] = rand.Next(0,100);
   Console.Write(" " + array[i]);
}
