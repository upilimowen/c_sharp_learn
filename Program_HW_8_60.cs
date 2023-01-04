bool FindNumber(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number)
                {
                    return true;    
                }
            }
        }                    
    }
    return false;
}

void MakeArray3D(int[,,] array)
{
    Random random = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int number = random.Next(-100, 100);
                while (FindNumber(array, number))
                {
                    number = random.Next(-100, 100);
                }                
                array[i, j, k] = random.Next(-100, 100);  
            }
        }              
    }
}

void WriteArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string result = "";
            for (int k = 0; k < array.GetLength(2); k++)
            {
                result = result + array[i, j, k] + "(" + i + "," + j + ","+ k + ") ";
            }
            Console.WriteLine(result);
        }                    
    }
}

Console.WriteLine("Введите, пожалуйста, размерость трехмерного массива.");
int sizeX = Convert.ToInt32(Console.ReadLine());
int sizeY = Convert.ToInt32(Console.ReadLine());
int sizeZ = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[sizeX, sizeY, sizeZ];

Console.WriteLine(sizeX + " | " + sizeY + " | " + sizeZ);
Console.WriteLine(array.GetLength(0) + " | " + array.GetLength(1) + " | " + array.GetLength(2));
MakeArray3D(array);
WriteArray3D(array);