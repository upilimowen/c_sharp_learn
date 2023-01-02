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

Console.WriteLine("Введите, пожалуйста, размерость двумерного массива.");
int sizeX = Convert.ToInt32(Console.ReadLine());
int sizeY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите, пожалуйста, позицию элемента массива.");
int position = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[sizeY, sizeX];

MakeArray(array);
Console.WriteLine("Задан массив:");
WriteArray(array);

//for (int l = 1; l < 13; l++)
//{
//    Console.Write(l-1);
//    int y = (l-1)/sizeX;
//    int x = (l-1) - sizeX*y;
//    Console.Write(" x " + x);
//    Console.Write(" y " + y);
//    Console.WriteLine(" значение " + array[y, x]);
//}

if ((position <1)|(position>(array.Length-1)))
{
    Console.WriteLine(position + " -> такого числа в массиве нет");    
}
else
{
    int y = (position-1)/sizeX;
    int x = (position-1) - sizeX*y;
    Console.WriteLine(position + " -> " + array[y, x]);   
}