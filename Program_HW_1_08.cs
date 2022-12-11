Console.WriteLine("Введите, пожалуйста, целое число!");
int numberA = Convert.ToInt32(Console.ReadLine());
int result = 0;
string resultStr = numberA.ToString() + " -> ";
if (numberA > 0)
{
    while (numberA >= (result + 2))
    {
        if (result > 0)
        {
            resultStr = resultStr + ", ";
        }
        result = result + 2;
        resultStr = resultStr + result.ToString();
    }
}
else
{
    while (numberA <= (result - 2))
    {
        if (result < 0)
        {
            resultStr = resultStr + ", ";
        }
        result = result - 2;
        resultStr = resultStr + result.ToString();
    }
}
Console.WriteLine($"Число {resultStr}");