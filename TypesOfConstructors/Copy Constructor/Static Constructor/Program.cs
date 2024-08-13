using System;

class MyClass
{
    public static int StaticValue;
    
    // Static constructor
    static MyClass()
    {
        Console.WriteLine("Static constructor called.");
        StaticValue = 42;
    }

    public MyClass()
    {
        Console.WriteLine("Instance constructor called.");
    }
}

class Program
{
    static void Main()
    {
        // Static constructor is called only once, before the first time the class is accessed.
        Console.WriteLine($"Static Value: {MyClass.StaticValue}");
        
        // Creating an instance of the class
        MyClass obj = new MyClass();
        
        // The static constructor won't be called again
        Console.WriteLine($"Static Value: {MyClass.StaticValue}");
    }
}
﻿
