// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Shape
{
    private int _x; private int _y; private int _z;

    public Shape(int a, int b, int c)
    {
        if(a + b <= c)
        {
            throw new ArgumentException("A triangle cannot exist");
        }

        if (a == 0)
        {
            throw new ArgumentException("A triangle cannot exist");
        }

        _x = a;
        _y = b; 
        _z = c; 
    }
}