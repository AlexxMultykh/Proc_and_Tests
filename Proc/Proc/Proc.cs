using System.IO;
using System;

class Program
{
    static void Main()
    {
        Proc1();
        Proc2();
        Proc3();
        Proc16();
        Proc17();
        Proc18();
        Proc19();
        Proc20();
        Proc21();
    }
    static void PowerA3(int A, ref int B)
    {
        B = (int)Math.Pow(A, 3);
    }
    static void Proc1()
    {
        int A = 0;
        PowerA3(3, ref A);
        Console.WriteLine(A);
    }
    static void PowerA234(int A, ref int B, ref int C, ref int D)
    {
        B = (int)Math.Pow(A, 2);
        C = (int)Math.Pow(A, 3);
        D = (int)Math.Pow(A, 4);
    }
    static void Proc2()
    {
        int A = 0;
        PowerA234(2, ref A);
        Console.WriteLine(A);
    }
    static double Mean(int X, int Y, double AMean, double GMean)
    {
        AMean = (X + Y) / 2;
        GMean = Math.Sqrt(X * Y);
    }
    static void Proc3()
    {
        int A = 4;
        int B = 9;
        int C = 16;
        int D = 1;
        Console.WriteLine(Mean(A, B, AMean, GMean));
        Console.WriteLine(Mean(A, C, AMean, GMean));
        Console.WriteLine(Mean(A, D, AMean, GMean));
    }
    static int Sign(double x)
    {
        if (x < 0)
            return -1;
        if (x == 0)
            return 0;
        return 1;
    }
    static void Proc16()
    {
        double A = 1.7;
        double B = 12.4;
        Console.WriteLine(Sign(A) + Sign(B));
    }
    static int RootsCount(int A, int B, int C)
    {
        double D = B * B + 4 * A * C;
        if (D < 0)
            return 0;
        if (D == 0)
            return 1;
        return 2;
    }
    static void Proc17()
    {
        int A = 1;
        int B = 5;
        int C = 6;
        Console.WriteLine(RootsCount(A, B, C));
    }
    static double CircleS(int R)
    {
        return Math.PI * R * R;
    }
    static void Proc18()
    {
        int R = 10;
        Console.WriteLine(CircleS(R));
    }
    static double RingS(int R1, int R2)
    {
        return (Math.PI * R1 * R1) - (Math.PI * R2 * R2);
    }
    static void Proc19()
    {
        int R1 = 10;
        int R2 = 7;
        Console.WriteLine(RingS(R1, R2));
    }
    static double TriangleP(double a, double h)
    {
        double b = Math.Sqrt((a / 2) * (a / 2) + h * h);
        return a + b + b;
    }
    static void Proc20()
    {
        double h = 8;
        double a = 12;
        Console.WriteLine(TriangleP(a, h));
    }
    static int SumRange(int A, int B)
    {

        int sum = 0;
        if (A > B)
        {
            return sum;
        }
        else
        {
            for (int i = A; i <= B; i++)
                sum += i;
            return sum;
        }
    }
    static void Proc21()
    {
        int A = 4;
        int B = 8;
        int C = 12;
        Console.WriteLine(SumRange(A, B));
        Console.WriteLine(SumRange(B, C));
    }
}