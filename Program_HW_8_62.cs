//запад-восток
int FillLineWУ(int[,] array, int numberW, int numberY, int numberN, int number)
{
    for (int i = numberW; i <= numberY; i++)
    {
        number = number + 1;
        array[i, numberN] = number; 
    } 
    return number;   
}

//восток-запад
int FillLineУW(int[,] array, int numberY, int numberW, int numberS, int number)
{
    for (int i = numberY; i >= numberW; i--)
    {
        number = number + 1;
        array[i, numberS] = number; 
    } 
    return number;   
}

//север-юг
int FillLineNS(int[,] array, int numberN, int numberS, int numberY, int number)
{
    for (int i = numberN; i <= numberS; i++)
    {
        number = number + 1;
        array[numberY, i] = number; 
    }  
    return number;  
}

//юг-север
int FillLineSN(int[,] array, int numberS, int numberN, int numberW, int number)
{
    for (int i = numberS; i >= numberN; i--)
    {
        number = number + 1;
        array[numberW, i] = number; 
    }  
    return number;  
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        string result = "";
        string str = "";
        for (int j = 0; j < array.GetLength(0); j++)
        {
            int num = array[j, i];
            if (num < 10)
            {
                str = "0" + num;    
            }
            else
            {
                str = "" + num;  
            }
            result = result + str + "  ";
        }
        Console.WriteLine(result);                 
    }
}

Console.WriteLine("Введите, пожалуйста, размерость двумерного массива.");
int sizeX = Convert.ToInt32(Console.ReadLine());
int sizeY = Convert.ToInt32(Console.ReadLine());
int numberW = 0;
int numberY = sizeX - 1;
int numberN = 0;
int numberS = sizeY - 1;
int number = 0;
int counter = 0;

int[,] array = new int[sizeX, sizeY];

int amt = sizeX * sizeY;

while (number < amt)
{
    if (counter == 0)
    { 
        number = FillLineWУ(array, numberW, numberY, numberN, number);
        numberN = numberN + 1;
        counter = 1;
    }
    else if (counter == 1)    
    {
        number = FillLineNS(array, numberN, numberS, numberY, number);
        numberY = numberY - 1;
        counter = 2;
    }
    else if (counter == 2)    
    {    
        number = FillLineУW(array, numberY, numberW, numberS, number);
        numberS = numberS - 1;
        counter = 3;
    }
    else if (counter == 3)    
    {    
        number = FillLineSN(array, numberS, numberN, numberW, number);
        numberW = numberW + 1;
        counter = 0;
    }  
}
WriteArray(array);