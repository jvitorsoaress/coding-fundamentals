using System;

/// <summary>
/// In this class, I'll be focusing on the Logical and Basic C# Programming stuffs
/// </summary>
public class HelloWorld
{
    public static void Main() //note: change the method signature so maybe you can run this
    {
        // So it all begins here:
        // Basically there is 2 ways to print on the Console
        Console.WriteLine("Hello, World!");
        Console.Write("Hello, ");
        Console.Write("World!"); //The difference is that .Write() doesn't break the line


        // And then we can add some variables, small spaces in memory to keep things saved while
        // executing our proggram. And for work with then we got some ways to do it:

        // Explicit Types - By using Primitive types:
        string text = "This is a string variable!";
        bool boolean = true; // but it can be false
        // There is so many ways to work with integer numbers:
        int number = 0; // int is the most common
        long otherNumber = 15;
        short otherNumber2 = 16; // 16-bit signed value
        ushort otherNumber3 = 17; // 16-bit not signed value
        // And there is 3 ways to represent not integer numbers:
        float floatNumber = 0.5f;
        decimal decimalNumber = 0.5M; // each one with its min and maximum size
        double doubleNumber = 0.5; // and each one with its purpose

        // Implicit Types - By using var Keyword
        var stringVariable = "The compiler is going to figure out what kinda of variable I am";
        var intVariable = 10; // and it also works with every type you know 
        
    }
} 