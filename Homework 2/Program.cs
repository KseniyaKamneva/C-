//Задача 10
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(num);
Console.WriteLine("Вторая цифра числа " + str[1]);

//Задача 13
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(num);
if (str.Length > 2)
{
  Console.WriteLine("Третья цифра  " + str[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет");
}

//Задача 15
Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

void Check(int num) 
{
  if (num == 6 || num == 7) 
  {
        Console.WriteLine("Это выходной день.");
  }
  else if (num < 1 || num > 7) 
  {
        Console.WriteLine("Нет такого дня недели.");
  }
  else 
  {
        Console.WriteLine("Это не выходной день.");
  }
}

Check(num);
