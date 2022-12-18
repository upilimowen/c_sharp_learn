Random random = new Random();
int number = random.Next(10000, 100000);
if (((number/10000) == (number%10)) & (((number - number/10000*10000)/1000) == number/10%10))
{
    Console.WriteLine(number + " -> да");
}
else
{
    Console.WriteLine(number + " -> нет");
}