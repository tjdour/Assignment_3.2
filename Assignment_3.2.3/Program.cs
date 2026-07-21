
using Assignment_3._2._3;

Circle circle1 = new Circle(3);
Circle circle2 = new Circle(5);

double totalArea = circle1 + circle2;
double areaDifference = circle1 - circle2;

Console.WriteLine($"Circle 1 area: {circle1.Area:F2}");
Console.WriteLine($"Circle 2 area: {circle2.Area:F2}");
Console.WriteLine($"Total area: {totalArea:F2}");
Console.WriteLine($"Area difference: {areaDifference:F2}");