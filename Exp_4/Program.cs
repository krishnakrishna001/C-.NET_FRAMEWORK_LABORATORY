using System;

class Number
{
    public int value;

    public Number(int v)
    {
        value = v;
    }

    // Unary Operator Overloading
    public static Number operator ++(Number n)
    {
        n.value++;
        return n;
    }

    // Binary Operator Overloading
    public static Number operator +(Number a, Number b)
    {
        return new Number(a.value + b.value);
    }
}

class Program
{
    static void Main()
    {
        Number n1 = new Number(10);
        Number n2 = new Number(20);

        ++n1; // Unary Operator

        Number n3 = n1 + n2; // Binary Operator

        Console.WriteLine("After Unary Operator (++): " + n1.value);
        Console.WriteLine("After Binary Operator (+): " + n3.value);
    }
}
