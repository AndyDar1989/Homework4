/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


int SumOfDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumOfDigits(number);
Console.WriteLine(result);