using System;

class Program
{
    static void Main(string[] args)
    {
        double x1 = -2;
        double y1 = 2;
        double x2 = 3;
        double y2 = 3 ;

        double distance = Dystans(x1, y1, x2, y2);
        Console.WriteLine("Długość odcinka: " + distance);
    }

    static double Dystans(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;

        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        return distance;
    }
}