void MakeArray(int[] array)
{
    Random random = new Random();
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        array[index] = random.Next(0, 100000);  
        Console.WriteLine(index);
        index = index + 1;          
    }
}

string MakeStringFromArray(int[] array)
{
    string result = ""; 
        int size = array.Length;
    int index = 0;
    while (index < size)
    {
        result = result + array[index] + ", ";
        index = index + 1;            
    }
    int resultSize = result.Length - 2;
    result = result.Substring(0, resultSize);

    return result;
}
int size = 8;
int[] array = new int[size];
MakeArray(array);
string result = MakeStringFromArray(array);   
Console.WriteLine(result + " -> [" + result +"]");