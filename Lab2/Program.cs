// See https://aka.ms/new-console-template for more information
//Name: Connor Diminico, Isaac Reyes
//Course Section: CPS 3330 Section 3

using Power; //Refrence to Library

class Program
{
    static void Main()
    {
        int a;
        int b;
        int c;

        Console.Write("Enter a number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a 2nd number: ");
        b = Convert.ToInt32(Console.ReadLine());

        double power = Class1.power(a, b); //Calling to Power Library 
        Console.WriteLine(a + " to the power of " + b + " = " + power);

        Console.Write("Enter a 3rd number: ");
        c = Convert.ToInt32(Console.ReadLine());

        double pow = Class1.pow(power, c); // Calling to Library again
        Console.WriteLine("The final result is " + pow); 
    }
}
