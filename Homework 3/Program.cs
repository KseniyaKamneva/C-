//Задача 19

Console.Write("Введите число: ");
string? num = Console.ReadLine();

void Checking(string num)
{
    if (num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine($"Число {num} палиндром.");
    }
    else 
        Console.WriteLine($"Число {num} не является палиндромом.");
}

if (num!.Length == 5)
{
    Checking(num);
}
else 
    Console.WriteLine($"Введите пятизначное число.");

//Задача 21

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coordName, string pointName)
{
    Console.Write($"Введите координаты {coordName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Result(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double Length =  Math.Round (Result(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка равна {Length}");

//Задача 23

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void numCubed(int[] num)
{
    int counter = 0;
    int length = num.Length;
    while (counter <  length)
    {
        num[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int index = 1;
    while (index < count)
    {
        Console.Write(arr[index]+ " ");
        index++;
    }
} 

int[] array = new int[num+1];
numCubed(array);
PrintArray(array);
