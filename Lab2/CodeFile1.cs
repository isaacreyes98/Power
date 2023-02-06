using Power;

class CodeFile1
{
    static void Main(string[] args)
    {
        int a;
        int b;
        int c;
        int d;

        Console.Write("Enter the number of integers you will provide: ");
        d = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a 2nd number: ");
        b = Convert.ToInt32(Console.ReadLine());

        if (d == 3)
        {
            double power = Class1.power(a, b);
            Console.Write("Enter a 3rd number: ");
            c = Convert.ToInt32(Console.ReadLine());

            double pow = Class1.pow(power, c); // Calling to Library again
            Console.WriteLine("The final result is " + pow);
        }
        else
        {
            double power = Class1.power(a, b); //Calling to Power Library 
            Console.WriteLine(a + " to the power of " + b + " = " + power);
        }

    }
}