/*
Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n
*/

int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    else if (numberN == 0)
        return AckermannFunction(numberM, 1);
    else
        return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
}

Console.WriteLine("Enter positive number M: ");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Enter positive number N: ");
int numberN = int.Parse(Console.ReadLine());

int result = AckermannFunction(numberM, numberN);
Console.WriteLine($"A(m,n) = {result}");