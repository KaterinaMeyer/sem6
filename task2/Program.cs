Console.WriteLine("введите значение b1 уравнения первой прямой");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1 уравнения первой прямой");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2 уравнения второй прямой");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2 уравнения второй прямой");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
