void MakeArray(int[,] array)
{
    Random random = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 10);  
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

Console.WriteLine("Введите, пожалуйста, размерость двумерного массива.");
int sizeX = Convert.ToInt32(Console.ReadLine());
int sizeY = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[sizeX, sizeY];
double[] arrayResilt = new double[sizeY];
MakeArray(array);
Console.WriteLine("Задан массив:");
WriteArray(array);
for (int i = 0; i < array.GetLength(1); i++)
{
    double result = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        result = result + array[j, i];
    } 
    result = Math.Round(result/array.GetLength(0),1);
    arrayResilt[i] = result;
}
Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int k = 0; k < arrayResilt.Length; k++)
{
    Console.Write(arrayResilt[k]);
    if (k < (arrayResilt.Length -1))
    {
        Console.Write("; ");
    }
    else
    {
        Console.Write(".");
    }
}