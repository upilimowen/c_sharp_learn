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

void MultipluArray(int[,]arrayA, int[,] arrayB, int[,] arrayC)
{     
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            arrayC[i,j] = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i,j] = arrayC[i,j] + arrayA[i,k] * arrayB[k,j];        
            }
        }
    }
}

Console.WriteLine("Введите, пожалуйста, размерость первой матрицы.");
int sizeXA = Convert.ToInt32(Console.ReadLine());
int sizeYA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите, пожалуйста, размерость второй матрицы.");
int sizeXB = Convert.ToInt32(Console.ReadLine());
int sizeYB = Convert.ToInt32(Console.ReadLine());

int[,] arrayA = new int[sizeYA, sizeXA];
int[,] arrayB = new int[sizeYB, sizeXB];
int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

if (arrayA.GetLength(1) != arrayB.GetLength(0))
{
    Console.WriteLine("Некорректные размерности умножаемых матриц. Количество строк первой матрицы должно быть равно количеству столбцов второй матрицы!");    
}
else
{
    MakeArray(arrayA);
    Console.WriteLine("Первая матрица:");
    WriteArray(arrayA);

    MakeArray(arrayB);
    Console.WriteLine("Вторая матрица:");
    WriteArray(arrayB);
    Console.WriteLine("Результат умножения матриц:");
    MultipluArray(arrayA, arrayB, arrayC);
    WriteArray(arrayC);
}