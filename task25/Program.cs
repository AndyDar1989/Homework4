/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


int PowerNumber(int num1, int num2)
{
    int num1_pow = 1;
    for (int count = 1; count <= num2; count++)
        num1_pow = num1_pow * num1;
    return num1_pow;
}


Console.Write("Enter number A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = PowerNumber(number1, number2);
Console.WriteLine($"the number {number1} to the power of {number2} is equal to {result} ");

