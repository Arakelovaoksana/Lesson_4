//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine()!);
int sum_digit = 0;
while (x > 0)
{
 sum_digit = sum_digit + x % 10;
   x = x / 10;
}
Console.WriteLine(sum_digit);
