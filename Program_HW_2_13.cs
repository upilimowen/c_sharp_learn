Console.WriteLine("Введите, пожалуйста, целое число!");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine(number +" -> третьей цифры нет");
}
else
{
    int result = number;
    while (result > 1000)
    {
        result = result/100;         
    }
    result = result%10;
    Console.WriteLine(number + " -> " + result);
}
