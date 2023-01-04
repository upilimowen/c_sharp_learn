int FillSum(int numberA, int numberB, int sum)
{
    if (numberA <= numberB)
    {
        sum = sum + numberA;
        numberA = numberA + 1;
        sum = FillSum(numberA, numberB, sum);
        
    }
    return sum;
}

Console.WriteLine("Введите, пожалуйста, первое целое число.");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите, пожалуйста, второе целое число.");
int numberB = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (numberA > numberB)
{
    int n = numberA;
    numberA = numberB;
    numberB = n;
}
sum = FillSum(numberA, numberB, sum);
Console.Write("M = " + numberA + "; M = " + numberB + " -> " + sum);