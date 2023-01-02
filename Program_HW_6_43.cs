//использование массивов - не самое оптимальный способ решения этой задачи,
//но так как тема урока называется "Одномерные массивы. Продолжение" то работаю с массивом
int[] array1 = new int[2];
int[] array2 = new int[2];

Console.WriteLine("Введите, пожалуйста, коэффициенты k и b уравнения y = k*x + b для первого уравнения");
array1[0] = Convert.ToInt32(Console.ReadLine());
array1[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Спасибо. Введите, пожалуйста, коэффициенты k и b уравнения y = k*x + b для второго уравнения");
array2[0] = Convert.ToInt32(Console.ReadLine());
array2[1] = Convert.ToInt32(Console.ReadLine());

if  (array1[0] == array2[0])
{ 
    if(array1[1] == array2[1])
    {
        Console.WriteLine("Это две идентичные прямые");
    }
    else
    {
        Console.WriteLine("Эти прямые не пересекаются");
    }
}    
else
{
    double resultX = (array2[1] - array1[1])/(array1[0] - array2[0]);
    double resultY = array1[0] * resultX + array1[1];
    Console.WriteLine("Точка пересечения этих прямых (" + resultX + ";" +resultY + ")");
}
