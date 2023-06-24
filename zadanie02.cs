﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współrzędne punktu początkowego (x1, y1):");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współrzędne punktu końcowego (x2, y2):");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        double dlugoscOdcinka = ObliczDlugoscOdcinka(x1, y1, x2, y2);
        Console.WriteLine($"Długość odcinka: {dlugoscOdcinka}");
    }

    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;

        double dlugosc = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

        return dlugosc;
    }
}