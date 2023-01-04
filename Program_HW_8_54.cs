void MakeArray(int[,] array)
{
    Random random = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-1000, 1000);  
        }          
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string result = "";
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + array[i, j] + " ";
        }
        Console.WriteLine(result);                
    }
}

void StreamlineArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] arrayResult = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayResult[j] = array[i, j];
        }
        Array.Sort(arrayResult);
        Array.Reverse(arrayResult);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = arrayResult[j];
        }
      
    }
}

Console.WriteLine("Введите, пожалуйста, размерость двумерного массива.");
int sizeX = Convert.ToInt32(Console.ReadLine());
int sizeY = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[sizeY, sizeX];

MakeArray(array);
Console.WriteLine("Задан массив:");
WriteArray(array);
StreamlineArray(array);
Console.WriteLine("Отсортированный массив:");
WriteArray(array);