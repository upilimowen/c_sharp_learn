void MakeArray(double[,] array)
{
    Random random = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //в условии задачи указано что числа должны быть вещественными, с точностью - один знак после запятой
            array[i, j] = Math.Round((random.Next(-1000, 1000) + random.NextDouble()), 1);  
        }          
    }
}

void WriteArray(double[,] array)
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

double[,] array = new double[sizeX, sizeY];

MakeArray(array);
WriteArray(array);