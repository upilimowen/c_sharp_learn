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

int FindString(int[,] array)
{
    int min = 0;
    int minNum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        min =  min + array[0, j];
    }
    
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumString = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumString =  sumString + array[i, j];
        }
        if (sumString < min)
        {
            min = sumString;
            minNum = i;
        }
    }
    return minNum;
}

Console.WriteLine("Введите, пожалуйста, размерость двумерного массива.");
int sizeX = Convert.ToInt32(Console.ReadLine());
int sizeY = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[sizeY, sizeX];

MakeArray(array);
Console.WriteLine("Задан массив:");
WriteArray(array);
int num = FindString(array);
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + num);