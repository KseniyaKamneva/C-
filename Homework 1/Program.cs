//Задача 2

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    Console.WriteLine(b);
}
if (a == b)
{
    Console.WriteLine("Числа одинаковые.");
}
if (a > b)
{
    Console.WriteLine(a);
}


//Задача 4

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число с: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > a)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine(max);

//Задача 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Число чётное.");
}
else
{
	Console.WriteLine("Число нечётное.");
}

//Задача 8

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i=0; i <= num; i++) 
{
   if (i%2 == 0)
   {
   		Console.Write("{0} ", i);
   }
}
