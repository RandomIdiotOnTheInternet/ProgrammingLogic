namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Part 1

        int myInt = 1;
        Console.WriteLine(myInt);
        double myDouble = 1.25D;
        Console.WriteLine(myDouble);
        float myFloat = 2.5F;
        Console.WriteLine(myFloat);
        char myChar = 'A';
        Console.WriteLine(myChar);
        bool myBool = true;
        Console.WriteLine(myBool);
        string myString = "Hi";
        Console.WriteLine(myString);

        // Part 2

        double almostTen = 9.78D;
        int oneLessThanTen = (int) almostTen;
        Console.WriteLine("Here's the integer, as a string: " + Convert.ToString(oneLessThanTen));
        bool isThatCool = true;
        Console.WriteLine("That's cool, right? " + Convert.ToString(isThatCool));

        // Part 3

        Console.WriteLine("What's your name?");
        string myName = Console.ReadLine();
        Console.WriteLine("What's your age?");
        var myAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hi there, " + myName + "! You're " + Convert.ToString(myAge) + " years old? Neat :)");

        // Part 4

        int num1 = 3;
        int num2 = 40;
        Console.WriteLine("num1 + 10 = " + Convert.ToString(num1 + 10));
        Console.WriteLine("num2 + 10 = " + Convert.ToString(num2 + 10));
        Console.WriteLine("num1 - 2 = " + Convert.ToString(num1 - 2));
        Console.WriteLine("num2 - 2 = " + Convert.ToString(num2 - 2));
        Console.WriteLine("num1 * 3 = " + Convert.ToString(num1 * 3));
        Console.WriteLine("num2 * 3 = " + Convert.ToString(num2 * 3));
        Console.WriteLine("num1 / 2 = " + Convert.ToString(num1 / 2));
        Console.WriteLine("num2 / 2 = " + Convert.ToString(num2 / 2));
        Console.WriteLine("num1 % 2 = " + Convert.ToString(num1 % 2));
        Console.WriteLine("num2 % 2 = " + Convert.ToString(num2 % 2));

        // Part 5

        float verySpecificFloat = 1.123456789F;
        double verySpecificDouble = 1.123456789D;
        Console.WriteLine(verySpecificFloat);
        Console.WriteLine(verySpecificDouble);

        // Part 6

        int justTen = 10;
        justTen--;
        Console.WriteLine(justTen);
        justTen++;
        Console.WriteLine(justTen);

    }
}
