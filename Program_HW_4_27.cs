Random random = new Random();
// так как в условии задачи не оговоривалось, рассмотрим частный случай - одно, двух, трех, четырех, пятизначные числа
int number= random.Next(0, 100000);
int result = number/10000 + number/1000%10 + number%1000/100 + number%100/10 + number%10;
Console.WriteLine(number + " ->" + result);