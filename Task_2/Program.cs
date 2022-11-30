Console.WriteLine("Введите число: ");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;

if (b>max)max=b;
if (c>max)max=c;

Console.WriteLine("Наибольшее число: {0}", max);