Console.WriteLine("Введите число: ");

int firstnumber = int.Parse(Console.ReadLine());
int secondnumber = int.Parse(Console.ReadLine());

if (firstnumber > secondnumber)
{
Console.WriteLine("{0} наибольшее число", firstnumber);
Console.WriteLine("{0} наименьшее число ", secondnumber);
}
else
{
Console.WriteLine("{0} наибольшее число ", secondnumber);
Console.WriteLine("{0} наименьшее число ", firstnumber);
}