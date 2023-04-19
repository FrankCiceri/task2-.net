using System;

public class Triangle : Shape
{
    private double _a;
    private double _b;
    private double _c;
    private double _height;
    public Triangle(double a,double b, double c, double _height)
    {
        this._a = a; 
        this._b = b; 
        this._c = c;
        this._height = _height;
    }


    public override double CalcArea()
    {
        double area = (_b * _height)/2;
        Console.WriteLine(area);
        return area;
    }

    public override double CalcPerimeter()
    {
        double perimeter = _a + _b + _c;
        Console.WriteLine(perimeter);
        return perimeter;
    }
}
