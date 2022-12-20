double myExponent(int arg1, int arg2)
{
    double result = 1;
    for (int i = 1; i <= arg2; i++)
    {
        result = result * arg1;
        Console.WriteLine(result);
    }
    return result;
}

Random random = new Random();
int number1= random.Next(0, 100);
int number2= random.Next(0, 10);
Console.WriteLine(number1 + ", " + number2 +  " -> " + myExponent(number1, number2));