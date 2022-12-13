Random random = new Random();
int number = random.Next(1, 8);
if (number >= 1 & number <= 5)
{
    Console.WriteLine(number + " -> нет");    
}
else if (number >= 6 & number <= 7)
{
    Console.WriteLine(number +  " -> да");    
}
else
{
    Console.WriteLine(number +  " -> что-то странное"); 
}   