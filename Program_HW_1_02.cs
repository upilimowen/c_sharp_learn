Console.WriteLine("Введите, пожалуйста, первое целое число!");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите, пожалуйста, второе целое число!");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"a = {numberA}; b = {numberB} -> max = {numberA}  min = {numberB}");
}
else
{
    Console.WriteLine($"a = {numberA}; b = {numberB} -> max = {numberB}  min = {numberA}");
}