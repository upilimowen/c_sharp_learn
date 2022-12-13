Random random = new Random();
int number = random.Next(100, 1000);
int result = number/10%10;
Console.WriteLine(number +" -> " + result);