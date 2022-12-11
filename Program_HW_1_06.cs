Console.WriteLine("Введите, пожалуйста, целое число!");
int numberA = Convert.ToInt32(Console.ReadLine());
int result = numberA%2;
if (result != 0)
{
    Console.WriteLine($"{numberA} -> нет");
}
else
{
    Console.WriteLine($"{numberA} -> да");
}    