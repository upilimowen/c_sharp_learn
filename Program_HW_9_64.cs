void FillString(string result, int number)
{
    result = result + " " + number;
    number = number - 1; 
    if (number > 0)
    {
        result = result + ",";
        FillString(result, number);
    }
    else
    {
        result = result + "''";
        Console.WriteLine(result);     
    }
}

Console.WriteLine("Введите, пожалуйста, натуральное число.");
int number = Convert.ToInt32(Console.ReadLine());
string result = "N = " + number + " -> ''";
FillString(result, number);