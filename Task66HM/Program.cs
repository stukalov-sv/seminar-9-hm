/*
Задайте значения M и N. Напишите программу, которая найдет
сумму натуральных элементов в промежутке от M и N
*/

int GetSumNumbers(int numberN, int numberM, int sum)
{
    if (numberN >= numberM)
    {
        int count = numberM;
        sum = sum + count;
        numberM++;
        return GetSumNumbers(numberN, numberM, sum);
    }
    else
        return (sum);
}

Console.WriteLine("Enter natural number M: ");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Enter natural number N: ");
int numberN = int.Parse(Console.ReadLine());

int sum = 0;

if (numberN > numberM)
{
    int result = GetSumNumbers(numberN, numberM, sum);
    Console.WriteLine("Amount of natural numbers: ");
    Console.WriteLine(result);
}
else
    Console.WriteLine("Incorrect data. N must be bigger than M");