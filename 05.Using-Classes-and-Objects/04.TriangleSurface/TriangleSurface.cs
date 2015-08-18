/*
 * Problem 4. Triangle surface
 * Write methods that calculate the surface of a triangle by given:
 *      Side and an altitude to it;
 *      Three sides;
 *      Two sides and an angle between them;
 * Use System.Math.
 */

using System;

class TriangleSurface
{
    static void Main()
    {
        float side = 3;
        float altitude = 5;
        Console.WriteLine("The surface calculated by side and altitude is " + sideAndAltitudeSurface(side, altitude));

        float sideA = 4.5f, sideB = 3.5f, sideC = 4;
        Console.WriteLine("The surface calculated by three sides is " + threeSidesSurface(sideA, sideB, sideC));

        float angle = 120;
        Console.WriteLine("The surface calculated by two sides and angle between them is " + twoSidesAndAngleSurface(sideA, sideB, angle));
    }

    static float sideAndAltitudeSurface(float side, float altitude)
    {
        return (side * altitude) / 2;
    }

    static float threeSidesSurface(float sideA, float sideB, float sideC)
    {
        float p = (sideA + sideB + sideC) / 2;
        return (float)Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }

    static float twoSidesAndAngleSurface (float sideA, float SideB, float angle)
    {
        return (float)(sideA * SideB * Math.Sin(angle * Math.PI / 180)) / 2; // Math.Sin работи в радиани и за това ъгъла трябва да се преобразува
    }
}