void MakeArray(int[] array)
{
    Random random = new Random();
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        array[index] = random.Next(100, 1000);  
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

Console.WriteLine("Введите, пожалуйста, размерость массива.");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
MakeArray(array);

int result = 0; 
int index = 0;
while (index < size)
{
    if ((array[index]%2) == 0)
    {
        result = result + 1;
    }
    index = index + 1;            
}
string strresult = MakeStringFromArray(array);   
Console.WriteLine("[" + strresult + "] -> " + result);