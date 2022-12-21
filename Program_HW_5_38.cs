void MakeArray(int[] array)
{
    Random random = new Random();
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        array[index] = random.Next(-1000, 1000);  
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
int resultMin = array[0];
int resultMax = array[0];

int index = 0;
while (index < size)
{
    if (array[index] < resultMin)
    {
        resultMin = array[index];
    }

    if (array[index] > resultMax)
    {
        resultMax = array[index];
    }
    index = index + 1;            
}

//так как работаем не с положительными, а с вещественными числами, 
//то разница разницу между максимальным и минимальным элементов вычисляется сложнее чем (max - min)

if ((resultMax > 0))
{
   result = resultMax - resultMin; 
}
else if ((resultMax < 0))
{
   result = (resultMax - resultMin) * (-1); 
}

string strresult = MakeStringFromArray(array);   
Console.WriteLine("[" + strresult + "] -> " + result);