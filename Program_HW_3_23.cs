Random random = new Random();
int number = random.Next(1, 100);
string resultString = number + " -> "; 
for (int i = 1; i <= number; i++)
{
   if (i > 1)
   {
        resultString = resultString + ", " +Math.Pow(i,3);
   }
   else
   {
        resultString = resultString + Math.Pow(i,3);
   } 
}
Console.WriteLine(resultString);