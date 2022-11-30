Console.WriteLine("Введите число: ");

int numbers = int.Parse(Console.ReadLine());

if ((numbers % 2) == 0)
{
    Console.WriteLine("Число {0} является четным ",  numbers);
}
else
{
 Console.WriteLine("Число {0} является нечетным ",  numbers);
}