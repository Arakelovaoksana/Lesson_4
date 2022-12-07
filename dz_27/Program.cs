//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();

Console.WriteLine("Введите число");
int c = int.Parse(Console.ReadLine()!);
int sum_digit = 0;
while (c > 0)
{
    int number = c % 10;
    c = c / 10;
    sum_digit = sum_digit + number;
}
Console.WriteLine(sum_digit);

