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

string answer = "";
//использование массивов - не самое оптимальный способ решения этой задачи,
//но так как тема урока называется "Одномерные массивы. Продолжение" то работаю с массивом
int[] array = new int[0];
int counter = 0;
int number = 0;

while (true)
{
    Console.WriteLine("Введите, пожалуйста, целое число. Если захотите прерваться - введите Q");
    answer = Console.ReadLine();
    if ((answer == "Q")|(answer == "q"))
        {
            break;
        }
    try
    {
        number = Convert.ToInt32(answer);
    }
    catch
    {
        Console.WriteLine("Извините, не понял?");    
    }
    Array.Resize(ref array, array.Length + 1);
    array[array.Length-1] = number;
    if (number > 0)
    {
        counter = counter + 1;
    }
}
string result = MakeStringFromArray(array); 
Console.WriteLine(result + " -> " + counter); 