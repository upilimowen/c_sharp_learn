Random random = new Random();
int xa = random.Next(-100000, 100000);
int ya = random.Next(-100000, 100000);
int za = random.Next(-100000, 100000);
int xb = random.Next(-100000, 100000);
int yb = random.Next(-100000, 100000);
int zb = random.Next(-100000, 100000);
// вычисляем расстояние между двумя точками
double result= Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
// округляем до двух знаков после запятой
result= Math.Round(result,2);
Console.WriteLine("A(" + xa + "," + ya + "," + za + "); B(" + xb + "," + yb + "," + zb + ") -> " + result);
