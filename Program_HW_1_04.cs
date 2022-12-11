Console.WriteLine("Введите, пожалуйста, первое целое число!");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите, пожалуйста, второе целое число!");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите, пожалуйста, третье целое число!");
int numberC = Convert.ToInt32(Console.ReadLine());
int numberMax = numberA;
if(numberB > numberMax)
{
    numberMax = numberB;
}
if(numberC > numberMax)
{
    numberMax = numberC;
}
Console.WriteLine($"{numberA}, {numberB} , {numberC} -> {numberMax}");