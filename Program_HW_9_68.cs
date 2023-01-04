static int A(int n, int m)
{
  if (n == 0) 
  {
    return m + 1;
  }  
  if (n != 0 && m == 0) 
  {
    return A(n - 1, 1);
  }  
  if (n > 0 && m > 0) 
  {
    return A(n - 1, A(n, m - 1));
  }  
  return A(n,m);
}
Console.WriteLine("Введите, пожалуйста, первое целое неотрицательное число.");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите, пожалуйста, второе целое неотрицательное число.");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = A(numberM, numberN);
Console.WriteLine(sum);